using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcVersionInfo2.xml' path='doc/member[@name="IDxcVersionInfo2"]/*' />
[NativeTypeName("struct IDxcVersionInfo2 : IDxcVersionInfo")]
[NativeInheritance("IDxcVersionInfo")]
internal unsafe partial struct IDxcVersionInfo2
{
    public void** lpVtbl;

    internal IDxcVersionInfo Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcVersionInfo2* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcVersionInfo2* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcVersionInfo2* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcVersionInfo2* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetVersion(IDxcVersionInfo2* pThis, [NativeTypeName("UINT32 *")] uint* pMajor, [NativeTypeName("UINT32 *")] uint* pMinor);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetFlags(IDxcVersionInfo2* pThis, [NativeTypeName("UINT32 *")] uint* pFlags);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetCommitInfo(IDxcVersionInfo2* pThis, [NativeTypeName("UINT32 *")] uint* pCommitCount, [NativeTypeName("char **")] sbyte** pCommitHash);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcVersionInfo2* pThis = &this)
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
        fixed (IDxcVersionInfo2* pThis = &this)
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
        fixed (IDxcVersionInfo2* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcVersionInfo2* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <inheritdoc cref="IDxcVersionInfo.GetVersion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetVersion([NativeTypeName("UINT32 *")] uint* pMajor, [NativeTypeName("UINT32 *")] uint* pMinor)
    {
        fixed (IDxcVersionInfo2* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVersion>((IntPtr)(lpVtbl[5]))(pThis, pMajor, pMinor);
        }
    }

    /// <inheritdoc cref="IDxcVersionInfo.GetFlags" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFlags([NativeTypeName("UINT32 *")] uint* pFlags)
    {
        fixed (IDxcVersionInfo2* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFlags>((IntPtr)(lpVtbl[6]))(pThis, pFlags);
        }
    }

    /// <include file='IDxcVersionInfo2.xml' path='doc/member[@name="IDxcVersionInfo2.GetCommitInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCommitInfo([NativeTypeName("UINT32 *")] uint* pCommitCount, [NativeTypeName("char **")] sbyte** pCommitHash)
    {
        fixed (IDxcVersionInfo2* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCommitInfo>((IntPtr)(lpVtbl[7]))(pThis, pCommitCount, pCommitHash);
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

        [NativeTypeName("HRESULT (UINT32 *, UINT32 *)")]
        public IntPtr GetVersion;

        [NativeTypeName("HRESULT (UINT32 *)")]
        public IntPtr GetFlags;

        [NativeTypeName("HRESULT (UINT32 *, char **)")]
        public IntPtr GetCommitInfo;
    }
}
