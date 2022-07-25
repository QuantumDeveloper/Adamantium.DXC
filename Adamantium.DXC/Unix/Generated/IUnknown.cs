using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IUnknown.xml' path='doc/member[@name="IUnknown"]/*' />
internal unsafe partial struct IUnknown
{
    public void** lpVtbl;

    /// <include file='IUnknown.xml' path='doc/member[@name="IUnknown.QueryInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <include file='IUnknown.xml' path='doc/member[@name="IUnknown.AddRef"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IUnknown*, nuint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUnknown.xml' path='doc/member[@name="IUnknown.Release"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IUnknown*, nuint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUnknown.xml' path='doc/member[@name="IUnknown.Dispose"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IUnknown*, void>)(lpVtbl[4]))((IUnknown*)Unsafe.AsPointer(ref this));
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IUnknown*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IUnknown*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IUnknown*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IUnknown*, void> Dispose;
    }
}
