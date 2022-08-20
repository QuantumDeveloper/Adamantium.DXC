using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Adamantium.DXC.Unix;

internal unsafe class UnixDxcCompiler : IDxcCompilerPlatform
{
    /// <summary>
    /// The <see cref="IDxcCompiler3"/> instance to use to create the bytecode for HLSL sources.
    /// </summary>
    private readonly ComPtr<IDxcCompiler3> DxcCompiler3;

    /// <summary>
    /// The <see cref="DxcUtils"/> instance to use to work with <see cref="UnixDxcCompiler"/>.
    /// </summary>
    private readonly ComPtr<IDxcUtils> DxcUtils;

    private readonly ComPtr<IDxcIncludeHandler> DxcIncludeHandler;

    public UnixDxcCompiler()
    {
        var result = DxcInterop.DxcCreateInstance(
            CLSID.DxcCompiler,
            IID.IDxcCompiler3,
            DxcCompiler3.GetVoidAddressOf());
        
        result = DxcInterop.DxcCreateInstance(
            CLSID.DxcUtils,
            IID.IDxcUtils,
            DxcUtils.GetVoidAddressOf());

        result = DxcUtils.Get()->CreateDefaultIncludeHandler(DxcIncludeHandler.GetAddressOf());
    }

    public void Compile(string filePath)
    {
        var filePathPtr = Marshal.StringToHGlobalUni(filePath);

        ComPtr<Adamantium.DXC.Unix.IDxcBlobEncoding> encoding = default;
        var hresult = DxcUtils.Get()->LoadFile((uint*)filePathPtr, (uint*)IntPtr.Zero, encoding.GetAddressOf());

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
        var arrayPtr = (uint**)allocated.AddrOfPinnedObject();

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
        
        Adamantium.DXC.Unix.DxcBuffer reflectionBuffer;
        reflectionBuffer.Ptr = reflectionData.Get()->GetBufferPointer();
        reflectionBuffer.Size = reflectionData.Get()->GetBufferSize();

        ComPtr<IDxcContainerReflection> reflection = default;
        DxcUtils.Get()->CreateReflection(&reflectionBuffer,
            IID.IDxcContainerReflection,
            reflection.GetVoidAddressOf());
    }

    public DxcCompilationResult CompileIntoSpirvFromFile(string filePath, string entryPoint, string targetProfile,
        CompilerOptions compilerOptions)
    {
        var fullPath = Path.GetFullPath(filePath);
        ComPtr<IDxcBlobEncoding> encoding = default;
        HRESULT hr;

        fixed (byte* pFilename = Encoding.UTF32.GetBytes(fullPath+'\0'))
        {
            hr = DxcUtils.Get()->LoadFile((uint*)pFilename, null, encoding.GetAddressOf());
        }

        DxcCompiler.CheckResult(hr, filePath);

        var buffer = new DxcBuffer();
        buffer.Ptr = encoding.Get()->GetBufferPointer();
        buffer.Size = (uint)encoding.Get()->GetBufferSize();

        return Compile(filePath, entryPoint, targetProfile, buffer, compilerOptions);
    }

    public DxcCompilationResult CompileIntoSpirvFromText(
        string sourceText, 
        string fileName, 
        string entryPoint, 
        string targetProfile,
        CompilerOptions compilerOptions)
    {
        ComPtr<IDxcBlobEncoding> encoding = default;
        HRESULT hr;

        var bytes = Encoding.UTF8.GetBytes(sourceText + '\0');

        fixed (byte* pSourceText = bytes)
        {
            hr = DxcUtils.Get()->CreateBlob(pSourceText, (uint)bytes.Length,0, encoding.GetAddressOf());
        }

        DxcCompiler.CheckResult(hr, fileName);

        var buffer = new DxcBuffer();
        buffer.Ptr = encoding.Get()->GetBufferPointer();
        buffer.Size = (uint)encoding.Get()->GetBufferSize();

        return Compile(fileName, entryPoint, targetProfile, buffer, compilerOptions);
    }

    private DxcCompilationResult Compile(
        string fileName,
        string entryPoint,
        string targetProfile,
        DxcBuffer buffer,
        CompilerOptions compilerOptions)
    {
        var dxcArgs = new List<string>()
        {
            fileName,
            "-E",
            entryPoint,
            "-T",
            targetProfile,
            "-spirv"
        };
        
        dxcArgs.AddRange(compilerOptions.Get());

        var intPtrArray = new IntPtr[dxcArgs.Count];
        for (var index = 0; index < dxcArgs.Count; index++)
        {
            var arg = dxcArgs[index];
            var bytes = Encoding.UTF32.GetBytes(arg+ "\0");
            var ptr1 = Marshal.AllocHGlobal(bytes.Length);
            Marshal.Copy(bytes, 0, ptr1, bytes.Length);
            
            intPtrArray[index] = ptr1;
        }
        
        ComPtr<IDxcResult> dxcResult = default;
        HRESULT result;
        fixed (IntPtr* p = intPtrArray)
        {
            result = DxcCompiler3.Get()->Compile(
                &buffer,
                (uint**)p,
                (uint)intPtrArray.Length,
                DxcIncludeHandler.Get(),
                IID.IDxcResult,
                dxcResult.GetVoidAddressOf());
        }

        HRESULT status;
        dxcResult.Get()->GetStatus(&status);

        DxcCompilationResult compilationResult = new DxcCompilationResult
        {
            Name = fileName,
            EntryPoint = entryPoint,
            TargetProfile = targetProfile
        };
        
        if (HRESULT.FAILED(status))
        {
            compilationResult.HasErrors = true;
            ComPtr<IDxcBlobEncoding> errorBlob = default;
            var res = dxcResult.Get()->GetErrorBuffer(errorBlob.GetAddressOf());
            if (HRESULT.SUCCEEDED(res))
            {
                var errors = (IntPtr)errorBlob.Get()->GetBufferPointer();
                var bufferSize = (uint)errorBlob.Get()->GetBufferSize();
                compilationResult.Errors = Encoding.UTF8.GetString((byte*)errors, (int)bufferSize);
                errorBlob.Dispose();
                dxcResult.Dispose();
            }

            return compilationResult;
        }
        
        ComPtr<IDxcBlob> code = default;
        dxcResult.Get()->GetResult(code.GetAddressOf());
        
        var sourcePtr = (IntPtr)code.Get()->GetBufferPointer();
        var size = (int)code.Get()->GetBufferSize();
        var bytecode = new byte[size];
        Marshal.Copy(sourcePtr, bytecode, 0, size);
        compilationResult.Bytecode = bytecode;
        
        code.Dispose();
        dxcResult.Dispose();

        return compilationResult;
    }

    public void Dispose()
    {
        DxcCompiler3.Dispose();
        DxcUtils.Dispose();
        DxcIncludeHandler.Dispose();
    }
}