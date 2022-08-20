using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcIncludeHandler.xml' path='doc/member[@name="IDxcIncludeHandler"]/*' />
[NativeTypeName("struct IDxcIncludeHandler : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcIncludeHandler
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, nuint>)(lpVtbl[1]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, nuint>)(lpVtbl[2]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, void>)(lpVtbl[4]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcIncludeHandler.xml' path='doc/member[@name="IDxcIncludeHandler.LoadSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LoadSource([NativeTypeName("LPCWSTR")] uint* pFilename, IDxcBlob** ppIncludeSource)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, uint*, IDxcBlob**, int>)(lpVtbl[5]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this), pFilename, ppIncludeSource);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, void> Dispose;

        [NativeTypeName("HRESULT (LPCWSTR, IDxcBlob **)")]
        public delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, uint*, IDxcBlob**, int> LoadSource;
    }
}
