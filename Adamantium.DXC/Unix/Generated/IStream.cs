using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IStream.xml' path='doc/member[@name="IStream"]/*' />
[NativeTypeName("struct IStream : ISequentialStream")]
[NativeInheritance("ISequentialStream")]
internal unsafe partial struct IStream
{
    public void** lpVtbl;

    internal ISequentialStream Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IStream* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IStream* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IStream* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IStream* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Read(IStream* pThis, void* pv, [NativeTypeName("ULONG")] UIntPtr cb, [NativeTypeName("ULONG *")] UIntPtr* pcbRead);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Write(IStream* pThis, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] UIntPtr cb, [NativeTypeName("ULONG *")] UIntPtr* pcbWritten);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Seek(IStream* pThis, LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _SetSize(IStream* pThis, ULARGE_INTEGER libNewSize);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _CopyTo(IStream* pThis, IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Commit(IStream* pThis, [NativeTypeName("DWORD")] uint grfCommitFlags);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Revert(IStream* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _LockRegion(IStream* pThis, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _UnlockRegion(IStream* pThis, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Stat(IStream* pThis, STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Clone(IStream* pThis, IStream** ppstm);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>((IntPtr)(lpVtbl[0]))(pThis, riid, ppvObject);
        }
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public UIntPtr AddRef()
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>((IntPtr)(lpVtbl[1]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public UIntPtr Release()
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IStream* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <inheritdoc cref="ISequentialStream.Read" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Read(void* pv, [NativeTypeName("ULONG")] UIntPtr cb, [NativeTypeName("ULONG *")] UIntPtr* pcbRead)
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Read>((IntPtr)(lpVtbl[5]))(pThis, pv, cb, pcbRead);
        }
    }

    /// <inheritdoc cref="ISequentialStream.Write" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] UIntPtr cb, [NativeTypeName("ULONG *")] UIntPtr* pcbWritten)
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Write>((IntPtr)(lpVtbl[6]))(pThis, pv, cb, pcbWritten);
        }
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.Seek"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Seek>((IntPtr)(lpVtbl[7]))(pThis, dlibMove, dwOrigin, plibNewPosition);
        }
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.SetSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSize>((IntPtr)(lpVtbl[8]))(pThis, libNewSize);
        }
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.CopyTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyTo>((IntPtr)(lpVtbl[9]))(pThis, pstm, cb, pcbRead, pcbWritten);
        }
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.Commit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Commit>((IntPtr)(lpVtbl[10]))(pThis, grfCommitFlags);
        }
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.Revert"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Revert()
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Revert>((IntPtr)(lpVtbl[11]))(pThis);
        }
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.LockRegion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_LockRegion>((IntPtr)(lpVtbl[12]))(pThis, libOffset, cb, dwLockType);
        }
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.UnlockRegion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnlockRegion>((IntPtr)(lpVtbl[13]))(pThis, libOffset, cb, dwLockType);
        }
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.Stat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Stat>((IntPtr)(lpVtbl[14]))(pThis, pstatstg, grfStatFlag);
        }
    }

    /// <include file='IStream.xml' path='doc/member[@name="IStream.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Clone(IStream** ppstm)
    {
        fixed (IStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Clone>((IntPtr)(lpVtbl[15]))(pThis, ppstm);
        }
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public IntPtr QueryInterface;

        [NativeTypeName("ULONG ()")]
        public IntPtr AddRef;

        [NativeTypeName("ULONG ()")]
        public IntPtr Release;

        [NativeTypeName("void () noexcept")]
        public IntPtr Dispose;

        [NativeTypeName("HRESULT (void *, ULONG, ULONG *)")]
        public IntPtr Read;

        [NativeTypeName("HRESULT (const void *, ULONG, ULONG *)")]
        public IntPtr Write;

        [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *)")]
        public IntPtr Seek;

        [NativeTypeName("HRESULT (ULARGE_INTEGER)")]
        public IntPtr SetSize;

        [NativeTypeName("HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER *, ULARGE_INTEGER *)")]
        public IntPtr CopyTo;

        [NativeTypeName("HRESULT (DWORD)")]
        public IntPtr Commit;

        [NativeTypeName("HRESULT ()")]
        public IntPtr Revert;

        [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD)")]
        public IntPtr LockRegion;

        [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD)")]
        public IntPtr UnlockRegion;

        [NativeTypeName("HRESULT (STATSTG *, DWORD)")]
        public IntPtr Stat;

        [NativeTypeName("HRESULT (IStream **)")]
        public IntPtr Clone;
    }
}
