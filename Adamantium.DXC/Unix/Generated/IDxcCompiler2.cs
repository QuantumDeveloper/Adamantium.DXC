using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcCompiler2.xml' path='doc/member[@name="IDxcCompiler2"]/*' />
[NativeTypeName("struct IDxcCompiler2 : IDxcCompiler")]
[NativeInheritance("IDxcCompiler")]
internal unsafe partial struct IDxcCompiler2
{
    public void** lpVtbl;

    internal IDxcCompiler Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompiler2*, Guid*, void**, int>)(lpVtbl[0]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompiler2*, nuint>)(lpVtbl[1]))((IDxcCompiler2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompiler2*, nuint>)(lpVtbl[2]))((IDxcCompiler2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcCompiler2*, void>)(lpVtbl[4]))((IDxcCompiler2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcCompiler.Compile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Compile(IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] uint* pSourceName, [NativeTypeName("LPCWSTR")] uint* pEntryPoint, [NativeTypeName("LPCWSTR")] uint* pTargetProfile, [NativeTypeName("LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompiler2*, IDxcBlob*, uint*, uint*, uint*, uint**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)(lpVtbl[5]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
    }

    /// <inheritdoc cref="IDxcCompiler.Preprocess" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Preprocess(IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] uint* pSourceName, [NativeTypeName("LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompiler2*, IDxcBlob*, uint*, uint**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)(lpVtbl[6]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
    }

    /// <inheritdoc cref="IDxcCompiler.Disassemble" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Disassemble(IDxcBlob* pSource, IDxcBlobEncoding** ppDisassembly)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompiler2*, IDxcBlob*, IDxcBlobEncoding**, int>)(lpVtbl[7]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, ppDisassembly);
    }

    /// <include file='IDxcCompiler2.xml' path='doc/member[@name="IDxcCompiler2.CompileWithDebug"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CompileWithDebug(IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] uint* pSourceName, [NativeTypeName("LPCWSTR")] uint* pEntryPoint, [NativeTypeName("LPCWSTR")] uint* pTargetProfile, [NativeTypeName("LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult, [NativeTypeName("LPWSTR *")] uint** ppDebugBlobName, IDxcBlob** ppDebugBlob)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompiler2*, IDxcBlob*, uint*, uint*, uint*, uint**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, uint**, IDxcBlob**, int>)(lpVtbl[8]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult, ppDebugBlobName, ppDebugBlob);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler2*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler2*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler2*, void> Dispose;

        [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcIncludeHandler *, IDxcOperationResult **)")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler2*, IDxcBlob*, uint*, uint*, uint*, uint**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int> Compile;

        [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcIncludeHandler *, IDxcOperationResult **)")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler2*, IDxcBlob*, uint*, uint**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int> Preprocess;

        [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobEncoding **)")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler2*, IDxcBlob*, IDxcBlobEncoding**, int> Disassemble;

        [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcIncludeHandler *, IDxcOperationResult **, LPWSTR *, IDxcBlob **)")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler2*, IDxcBlob*, uint*, uint*, uint*, uint**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, uint**, IDxcBlob**, int> CompileWithDebug;
    }
}
