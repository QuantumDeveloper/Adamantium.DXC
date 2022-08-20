using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IStream.xml' path='doc/member[@name="IStream"]/*' />
[NativeTypeName("struct IStream : ISequentialStream")]
[NativeInheritance("ISequentialStream")]
internal unsafe partial struct IStream
{
    public void** lpVtbl;

    internal ISequentialStream Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, Guid*, void**, int>)(lpVtbl[0]))((IStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, nuint>)(lpVtbl[1]))((IStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, nuint>)(lpVtbl[2]))((IStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IStream*, void>)(lpVtbl[4]))((IStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISequentialStream.Read" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Read(void* pv, [NativeTypeName("ULONG")] nuint cb, [NativeTypeName("ULONG *")] nuint* pcbRead)
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, void*, nuint, nuint*, int>)(lpVtbl[5]))((IStream*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
    }

    /// <inheritdoc cref="ISequentialStream.Write" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] nuint cb, [NativeTypeName("ULONG *")] nuint* pcbWritten)
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, void*, nuint, nuint*, int>)(lpVtbl[6]))((IStream*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.Seek"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IStream*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.SetSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, ULARGE_INTEGER, int>)(lpVtbl[8]))((IStream*)Unsafe.AsPointer(ref this), libNewSize);
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.CopyTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[9]))((IStream*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.Commit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, uint, int>)(lpVtbl[10]))((IStream*)Unsafe.AsPointer(ref this), grfCommitFlags);
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.Revert"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, int>)(lpVtbl[11]))((IStream*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.LockRegion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[12]))((IStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.UnlockRegion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[13]))((IStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.Stat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, STATSTG*, uint, int>)(lpVtbl[14]))((IStream*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Clone(IStream** ppstm)
    {
        return ((delegate* unmanaged[Cdecl]<IStream*, IStream**, int>)(lpVtbl[15]))((IStream*)Unsafe.AsPointer(ref this), ppstm);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IStream*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IStream*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IStream*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IStream*, void> Dispose;

        [NativeTypeName("HRESULT (void *, ULONG, ULONG *)")]
        public delegate* unmanaged[Cdecl]<IStream*, void*, nuint, nuint*, int> Read;

        [NativeTypeName("HRESULT (const void *, ULONG, ULONG *)")]
        public delegate* unmanaged[Cdecl]<IStream*, void*, nuint, nuint*, int> Write;

        [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *)")]
        public delegate* unmanaged[Cdecl]<IStream*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> Seek;

        [NativeTypeName("HRESULT (ULARGE_INTEGER)")]
        public delegate* unmanaged[Cdecl]<IStream*, ULARGE_INTEGER, int> SetSize;

        [NativeTypeName("HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER *, ULARGE_INTEGER *)")]
        public delegate* unmanaged[Cdecl]<IStream*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int> CopyTo;

        [NativeTypeName("HRESULT (DWORD)")]
        public delegate* unmanaged[Cdecl]<IStream*, uint, int> Commit;

        [NativeTypeName("HRESULT ()")]
        public delegate* unmanaged[Cdecl]<IStream*, int> Revert;

        [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD)")]
        public delegate* unmanaged[Cdecl]<IStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> LockRegion;

        [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD)")]
        public delegate* unmanaged[Cdecl]<IStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> UnlockRegion;

        [NativeTypeName("HRESULT (STATSTG *, DWORD)")]
        public delegate* unmanaged[Cdecl]<IStream*, STATSTG*, uint, int> Stat;

        [NativeTypeName("HRESULT (IStream **)")]
        public delegate* unmanaged[Cdecl]<IStream*, IStream**, int> Clone;
    }
}
