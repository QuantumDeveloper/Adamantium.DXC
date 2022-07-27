using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Adamantium.DXC.Windows;

internal unsafe class WindowsDxcCompiler : IDxcCompilerPlatform
{
    /// <summary>
    /// The <see cref="IDxcCompiler3"/> instance to use to create the bytecode for HLSL sources.
    /// </summary>
    private readonly ComPtr<IDxcCompiler3> DxcCompiler3;

    /// <summary>
    /// The <see cref="DxcUtils"/> instance to use to work with <see cref="WindowsDxcCompiler"/>.
    /// </summary>
    private readonly ComPtr<IDxcUtils> DxcUtils;

    private readonly ComPtr<IDxcIncludeHandler> DxcIncludeHandler;

    public WindowsDxcCompiler()
    {
        using ComPtr<IDxcCompiler3> dxcCompiler = default;
        using ComPtr<IDxcUtils> dxcUtils = default;
        using ComPtr<IDxcIncludeHandler> dxcIncludeHandler = default;

        var result= DxcInterop.DxcCreateInstance(
            CLSID.DxcCompiler,
            IID.IDxcCompiler3,
            dxcCompiler.GetVoidAddressOf());
        
        result = DxcInterop.DxcCreateInstance(
            CLSID.DxcUtils,
            IID.IDxcUtils,
            dxcUtils.GetVoidAddressOf());

        result = dxcUtils.Get()->CreateDefaultIncludeHandler(dxcIncludeHandler.GetAddressOf());

        DxcCompiler3 = dxcCompiler.Move();
        DxcUtils = dxcUtils.Move();
        DxcIncludeHandler = dxcIncludeHandler.Move();
    }

    public void Compile(string filePath)
    {
        var filePathPtr = Marshal.StringToHGlobalUni(filePath);

        ComPtr<IDxcBlobEncoding> encoding = default;
        var hresult = DxcUtils.Get()->LoadFile((ushort*)filePathPtr, (uint*)IntPtr.Zero, encoding.GetAddressOf());

        var ptr = encoding.Get()->GetBufferPointer();
        var size = (uint)encoding.Get()->GetBufferSize();
        BOOL known = default;
        uint codePage = default;
        encoding.Get()->GetEncoding(&known, &codePage);

        var buffer = new DxcBuffer();
        buffer.Ptr = ptr;
        buffer.Size = size;
        
        var dxcArgs = new List<string>
        {
            "simpleVertex.hlsl",
            "-E",
            "LightVertexShader",
            "-T",
            "vs_6_6",
            "-Zi",
            "-Qstrip_debug",
            "-Qstrip_reflect"
        };

        var intPtrArray = new List<IntPtr>();
        foreach (var arg in dxcArgs)
        {
            intPtrArray.Add(Marshal.StringToHGlobalUni(arg));
        }
        
        var allocated = GCHandle.Alloc(intPtrArray.ToArray(), GCHandleType.Pinned);
        var arrayPtr = (ushort**)allocated.AddrOfPinnedObject();

        ComPtr<IDxcResult> compileResult = default;
        var result = DxcCompiler3.Get()->Compile(
            &buffer,
            arrayPtr,
            (uint)dxcArgs.Count,
            DxcIncludeHandler.Get(),
            IID.IDxcResult,
            compileResult.GetVoidAddressOf());
        
        allocated.Free();
        
        if (HRESULT.FAILED(result))
        {
            return;
        }

        HRESULT status;
        compileResult.Get()->GetStatus(&status);

        if (HRESULT.FAILED(status))
        {
            
        }
        
        ComPtr<IDxcBlobEncoding> errorBlob = default;
        var res = compileResult.Get()->GetErrorBuffer(errorBlob.GetAddressOf());
        if (HRESULT.SUCCEEDED(res))
        {
            var errors = (IntPtr)errorBlob.Get()->GetBufferPointer();
            var str = Marshal.PtrToStringAnsi(errors);
            Console.WriteLine(str);
        }

        var num = compileResult.Get()->GetNumOutputs();
        for (int i = 0; i < num; i++)
        {
            var output = compileResult.Get()->GetOutputByIndex((uint)i);
        }
        
        ComPtr<IDxcBlob> shader = default;
        ComPtr<IDxcBlobUtf16> shaderName = default;
        compileResult.Get()->GetOutput(DXC_OUT_KIND.DXC_OUT_ERRORS,
            IID.IDxcBlob,
            shader.GetVoidAddressOf(),
            shaderName.GetAddressOf());
        
        var errors2 = (IntPtr)shader.Get()->GetBufferPointer();
        var str2 = Marshal.PtrToStringAnsi(errors2);
        Console.WriteLine(str2);
        
        ComPtr<IDxcBlob> reflectionData = default;
        ComPtr<IDxcBlobUtf16> shaderName1 = default;
        compileResult.Get()->GetOutput(DXC_OUT_KIND.DXC_OUT_REFLECTION,
            IID.IDxcBlob,
            reflectionData.GetVoidAddressOf(),
            shaderName1.GetAddressOf());
        
        DxcBuffer reflectionBuffer;
        reflectionBuffer.Ptr = reflectionData.Get()->GetBufferPointer();
        reflectionBuffer.Size = reflectionData.Get()->GetBufferSize();

        ComPtr<IDxcContainerReflection> reflection = default;
        DxcUtils.Get()->CreateReflection(&reflectionBuffer,
            IID.IDxcContainerReflection,
            reflection.GetVoidAddressOf());
    }

    public DXCCompileResult CompileIntoSpirv(string filePath, string entryPoint, string targetProfile, params string[] compileArguments)
    {
        var fullPath = Path.GetFullPath(filePath);
        ComPtr<IDxcBlobEncoding> encoding = default;
        HRESULT hr;

        fixed (byte* pFilename = Encoding.UTF32.GetBytes(fullPath))
        {
            hr = DxcUtils.Get()->LoadFile((ushort*)pFilename, null, encoding.GetAddressOf());
        }
        
        var buffer = new DxcBuffer();
        buffer.Ptr = encoding.Get()->GetBufferPointer();
        buffer.Size = (uint)encoding.Get()->GetBufferSize();
        
        var dxcArgs = new List<string>()
        {
            filePath,
            "-E",
            entryPoint,
            "-T",
            targetProfile,
            "-spirv"
        };
        
        dxcArgs.AddRange(compileArguments);

        var intPtrArray = new List<IntPtr>();
        foreach (var arg in dxcArgs)
        {
            intPtrArray.Add(Marshal.StringToHGlobalUni(arg));
        }
        
        var allocated = GCHandle.Alloc(intPtrArray.ToArray(), GCHandleType.Pinned);
        var arrayPtr = (ushort**)allocated.AddrOfPinnedObject();

        ComPtr<IDxcResult> dxcResult = default;
        var result =  DxcCompiler3.Get()->Compile(
            &buffer,
            arrayPtr,
            (uint)dxcArgs.Count,
            DxcIncludeHandler.Get(),
            IID.IDxcResult,
            dxcResult.GetVoidAddressOf());
        
        allocated.Free();

        HRESULT status;
        dxcResult.Get()->GetStatus(&status);

        DXCCompileResult compileResult = new DXCCompileResult();
        if (HRESULT.FAILED(status))
        {
            compileResult.HasErrors = true;
            ComPtr<IDxcBlobEncoding> errorBlob = default;
            var res = dxcResult.Get()->GetErrorBuffer(errorBlob.GetAddressOf());
            if (HRESULT.SUCCEEDED(res))
            {
                var errors = (IntPtr)errorBlob.Get()->GetBufferPointer();
                var errorsString = Marshal.PtrToStringAnsi(errors);
                compileResult.Errors = errorsString;
            }
            
            return compileResult;
        }
        
        ComPtr<IDxcBlob> code = default;
        dxcResult.Get()->GetResult(code.GetAddressOf());
        compileResult.Source = (IntPtr)code.Get()->GetBufferPointer();
        compileResult.Size = (uint)code.Get()->GetBufferSize();

        return compileResult;
    }
}