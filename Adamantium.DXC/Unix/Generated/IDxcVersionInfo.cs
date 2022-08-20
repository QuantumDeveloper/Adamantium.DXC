using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcVersionInfo.xml' path='doc/member[@name="IDxcVersionInfo"]/*' />
[NativeTypeName("struct IDxcVersionInfo : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcVersionInfo
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo*, Guid*, void**, int>)(lpVtbl[0]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo*, nuint>)(lpVtbl[1]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo*, nuint>)(lpVtbl[2]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcVersionInfo*, void>)(lpVtbl[4]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcVersionInfo.xml' path='doc/member[@name="IDxcVersionInfo.GetVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetVersion([NativeTypeName("UINT32 *")] uint* pMajor, [NativeTypeName("UINT32 *")] uint* pMinor)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo*, uint*, uint*, int>)(lpVtbl[5]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pMajor, pMinor);
    }

    /// <include file='IDxcVersionInfo.xml' path='doc/member[@name="IDxcVersionInfo.GetFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFlags([NativeTypeName("UINT32 *")] uint* pFlags)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo*, uint*, int>)(lpVtbl[6]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pFlags);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo*, void> Dispose;

        [NativeTypeName("HRESULT (UINT32 *, UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo*, uint*, uint*, int> GetVersion;

        [NativeTypeName("HRESULT (UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo*, uint*, int> GetFlags;
    }
}
