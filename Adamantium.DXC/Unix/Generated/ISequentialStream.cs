using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='ISequentialStream.xml' path='doc/member[@name="ISequentialStream"]/*' />
[NativeTypeName("struct ISequentialStream : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct ISequentialStream
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int>)(lpVtbl[0]))((ISequentialStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<ISequentialStream*, nuint>)(lpVtbl[1]))((ISequentialStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<ISequentialStream*, nuint>)(lpVtbl[2]))((ISequentialStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<ISequentialStream*, void>)(lpVtbl[4]))((ISequentialStream*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISequentialStream.xml' path='doc/member[@name="ISequentialStream.Read"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Read(void* pv, [NativeTypeName("ULONG")] nuint cb, [NativeTypeName("ULONG *")] nuint* pcbRead)
    {
        return ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, nuint, nuint*, int>)(lpVtbl[5]))((ISequentialStream*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
    }

    /// <include file='ISequentialStream.xml' path='doc/member[@name="ISequentialStream.Write"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] nuint cb, [NativeTypeName("ULONG *")] nuint* pcbWritten)
    {
        return ((delegate* unmanaged[Cdecl]<ISequentialStream*, void*, nuint, nuint*, int>)(lpVtbl[6]))((ISequentialStream*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<ISequentialStream*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<ISequentialStream*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<ISequentialStream*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<ISequentialStream*, void> Dispose;

        [NativeTypeName("HRESULT (void *, ULONG, ULONG *)")]
        public delegate* unmanaged[Cdecl]<ISequentialStream*, void*, nuint, nuint*, int> Read;

        [NativeTypeName("HRESULT (const void *, ULONG, ULONG *)")]
        public delegate* unmanaged[Cdecl]<ISequentialStream*, void*, nuint, nuint*, int> Write;
    }
}
