using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcCompiler3.xml' path='doc/member[@name="IDxcCompiler3"]/*' />
[NativeTypeName("struct IDxcCompiler3 : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcCompiler3
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, Guid*, void**, int>)(lpVtbl[0]))((IDxcCompiler3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, nuint>)(lpVtbl[1]))((IDxcCompiler3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, nuint>)(lpVtbl[2]))((IDxcCompiler3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, void>)(lpVtbl[4]))((IDxcCompiler3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcCompiler3.xml' path='doc/member[@name="IDxcCompiler3.Compile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Compile([NativeTypeName("const DxcBuffer *")] DxcBuffer* pSource, [NativeTypeName("LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount, IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("REFIID")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, DxcBuffer*, uint**, uint, IDxcIncludeHandler*, Guid*, void**, int>)(lpVtbl[5]))((IDxcCompiler3*)Unsafe.AsPointer(ref this), pSource, pArguments, argCount, pIncludeHandler, riid, ppResult);
    }

    /// <include file='IDxcCompiler3.xml' path='doc/member[@name="IDxcCompiler3.Disassemble"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Disassemble([NativeTypeName("const DxcBuffer *")] DxcBuffer* pObject, [NativeTypeName("REFIID")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompiler3*, DxcBuffer*, Guid*, void**, int>)(lpVtbl[6]))((IDxcCompiler3*)Unsafe.AsPointer(ref this), pObject, riid, ppResult);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler3*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler3*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler3*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler3*, void> Dispose;

        [NativeTypeName("HRESULT (const DxcBuffer *, LPCWSTR *, UINT32, IDxcIncludeHandler *, REFIID, LPVOID *)")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler3*, DxcBuffer*, uint**, uint, IDxcIncludeHandler*, Guid*, void**, int> Compile;

        [NativeTypeName("HRESULT (const DxcBuffer *, REFIID, LPVOID *)")]
        public delegate* unmanaged[Cdecl]<IDxcCompiler3*, DxcBuffer*, Guid*, void**, int> Disassemble;
    }
}
