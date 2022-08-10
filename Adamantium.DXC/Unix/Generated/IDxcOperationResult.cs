using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcOperationResult.xml' path='doc/member[@name="IDxcOperationResult"]/*' />
[NativeTypeName("struct IDxcOperationResult : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcOperationResult
{
    public void** lpVtbl;

    internal IUnknown Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcOperationResult* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcOperationResult* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcOperationResult* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcOperationResult* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetStatus(IDxcOperationResult* pThis, HRESULT* pStatus);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetResult(IDxcOperationResult* pThis, IDxcBlob** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetErrorBuffer(IDxcOperationResult* pThis, IDxcBlobEncoding** ppErrors);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcOperationResult* pThis = &this)
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
        fixed (IDxcOperationResult* pThis = &this)
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
        fixed (IDxcOperationResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcOperationResult* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <include file='IDxcOperationResult.xml' path='doc/member[@name="IDxcOperationResult.GetStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStatus(HRESULT* pStatus)
    {
        fixed (IDxcOperationResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStatus>((IntPtr)(lpVtbl[5]))(pThis, pStatus);
        }
    }

    /// <include file='IDxcOperationResult.xml' path='doc/member[@name="IDxcOperationResult.GetResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetResult(IDxcBlob** ppResult)
    {
        fixed (IDxcOperationResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetResult>((IntPtr)(lpVtbl[6]))(pThis, ppResult);
        }
    }

    /// <include file='IDxcOperationResult.xml' path='doc/member[@name="IDxcOperationResult.GetErrorBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetErrorBuffer(IDxcBlobEncoding** ppErrors)
    {
        fixed (IDxcOperationResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetErrorBuffer>((IntPtr)(lpVtbl[7]))(pThis, ppErrors);
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

        [NativeTypeName("HRESULT (HRESULT *)")]
        public IntPtr GetStatus;

        [NativeTypeName("HRESULT (IDxcBlob **)")]
        public IntPtr GetResult;

        [NativeTypeName("HRESULT (IDxcBlobEncoding **)")]
        public IntPtr GetErrorBuffer;
    }
}
