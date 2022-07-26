﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Adamantium.DXC.Unix;

public unsafe class UnixDxcCompiler
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
        using ComPtr<IDxcCompiler3> dxcCompiler = default;
        using ComPtr<IDxcUtils> dxcUtils = default;
        using ComPtr<IDxcIncludeHandler> dxcIncludeHandler = default;

        //???
        var result = DxcInterop.DxcCreateInstance(
            CLSID.DxcCompiler,
            IID.IDxcCompiler3,
            dxcCompiler.GetVoidAddressOf());
        
        // result = DxcInterop.DxcCreateInstance(
        //     (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID.DxcCompiler)),
        //     (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDxcCompiler3)),
        //     dxcCompiler.GetVoidAddressOf());
        
        // result = DxcInterop.DxcCreateInstance(
        //     CLSID.DxcUtils.GetPointer(),
        //     IID.IDxcUtils.GetPointer(),
        //     dxcUtils.GetVoidAddressOf());

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
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDxcResult)),
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
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IID_IDxcBlob)),
            shader.GetVoidAddressOf(),
            shaderName.GetAddressOf());
        
        var errors2 = (IntPtr)shader.Get()->GetBufferPointer();
        var str2 = Marshal.PtrToStringAnsi(errors2);
        Console.WriteLine(str2);
        
        ComPtr<IDxcBlob> reflectionData = default;
        ComPtr<IDxcBlobUtf16> shaderName1 = default;
        compileResult.Get()->GetOutput(DXC_OUT_KIND.DXC_OUT_REFLECTION,
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IID_IDxcBlob)),
            reflectionData.GetVoidAddressOf(),
            shaderName1.GetAddressOf());
        
        Adamantium.DXC.Unix.DxcBuffer reflectionBuffer;
        reflectionBuffer.Ptr = reflectionData.Get()->GetBufferPointer();
        reflectionBuffer.Size = reflectionData.Get()->GetBufferSize();

        ComPtr<IDxcContainerReflection> reflection = default;
        DxcUtils.Get()->CreateReflection(&reflectionBuffer,
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDxcContainerReflection)),
            reflection.GetVoidAddressOf());
    }

    public unsafe void CompileIntoSpirv(string filePath)
    {
        var fullPath = Path.GetFullPath(filePath);
        ComPtr<Adamantium.DXC.Unix.IDxcBlobEncoding> encoding = default;
        HRESULT hr;

        fixed (byte* pFilename = Encoding.UTF32.GetBytes(fullPath+'\0'))
        {
            hr = DxcUtils.Get()->LoadFile((uint*)pFilename, null, encoding.GetAddressOf());
        }
        
        var ptr = encoding.Get()->GetBufferPointer();
        var size = (uint)encoding.Get()->GetBufferSize();
        BOOL known = default;
        uint codePage = default;
        encoding.Get()->GetEncoding(&known, &codePage);

        var buffer = new DxcBuffer();
        buffer.Ptr = ptr;
        buffer.Size = size;
        
        var dxcArgs = new string[]
        {
            "simpleVertex.hlsl",
            "-E",
            "LightVertexShader",
            "-T",
            "vs_6_6",
            "-spirv",
            "-all-resources-bound", // nVidia: This allows for the compiler to do a better job at optimizing texture accesses. We have seen frame rate improvements of > 1% when toggling this flag on.
            "-enable-16bit-types", // VK_KHR_shader_float16_int8
            "-fvk-use-dx-layout", // memory layout for resources
            "-fspv-target-env=vulkan1.1", // Vulkan version
            "-fspv-extension=SPV_GOOGLE_hlsl_functionality1",
            "-fspv-extension=SPV_GOOGLE_user_type",
            "-fspv-reflect"
        };

        var intPtrArray = new IntPtr[dxcArgs.Length];
        for (var index = 0; index < dxcArgs.Length; index++)
        {
            var arg = dxcArgs[index];
            var bytes = Encoding.UTF32.GetBytes(arg+ "\0");
            var ptr1 = Marshal.AllocHGlobal(bytes.Length);
            Marshal.Copy(bytes, 0, ptr1, bytes.Length);
            
            intPtrArray[index] = ptr1;
        }
        
        ComPtr<IDxcResult> compileResult = default;
        HRESULT result;
        fixed (IntPtr* p = intPtrArray)
        {
            result = DxcCompiler3.Get()->Compile(
                &buffer,
                (uint**)p,
                (uint)intPtrArray.Length,
                DxcIncludeHandler.Get(),
                (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDxcResult)),
                compileResult.GetVoidAddressOf());
        }

        if (HRESULT.FAILED(result))
        {
            return;
        }
        
        HRESULT status;
        compileResult.Get()->GetStatus(&status);

        if (HRESULT.FAILED(status))
        {
            ComPtr<Adamantium.DXC.Unix.IDxcBlobEncoding> errorBlob = default;
            var res = compileResult.Get()->GetErrorBuffer(errorBlob.GetAddressOf());
            if (HRESULT.SUCCEEDED(res))
            {
                var errors = (IntPtr)errorBlob.Get()->GetBufferPointer();
                var bufferSize = (uint)errorBlob.Get()->GetBufferSize();
                var str = Encoding.UTF8.GetString((byte*)errors, (int)bufferSize);
                var str2 = Encoding.ASCII.GetString((byte*)errors, (int)bufferSize);
                Console.WriteLine(str);
            }
            
            return;
        }
        
        if (compileResult.Get()->HasOutput(DXC_OUT_KIND.DXC_OUT_OBJECT))
        {
            ComPtr<IDxcBlob> shader = default;
            ComPtr<IDxcBlobUtf16> shaderName = default;
            var output = compileResult.Get()->GetOutput(
                DXC_OUT_KIND.DXC_OUT_OBJECT,
                (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IID_IDxcBlob)),
                shader.GetVoidAddressOf(),
                shaderName.GetAddressOf()
            );

            ComPtr<IDxcBlob> code = default;
            compileResult.Get()->GetResult(code.GetAddressOf());
            var ptr1 = code.Get()->GetBufferPointer();
            var size1 = (uint)code.Get()->GetBufferSize();
        }
    }
}