using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection"]/*' />
[NativeTypeName("struct IDxcContainerReflection : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcContainerReflection
{
    public void** lpVtbl;

    internal IUnknown Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcContainerReflection* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcContainerReflection* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcContainerReflection* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcContainerReflection* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Load(IDxcContainerReflection* pThis, IDxcBlob* pContainer);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetPartCount(IDxcContainerReflection* pThis, [NativeTypeName("UINT32 *")] uint* pResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetPartKind(IDxcContainerReflection* pThis, [NativeTypeName("UINT32")] uint idx, [NativeTypeName("UINT32 *")] uint* pResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetPartContent(IDxcContainerReflection* pThis, [NativeTypeName("UINT32")] uint idx, IDxcBlob** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _FindFirstPartKind(IDxcContainerReflection* pThis, [NativeTypeName("UINT32")] uint kind, [NativeTypeName("UINT32 *")] uint* pResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetPartReflection(IDxcContainerReflection* pThis, [NativeTypeName("UINT32")] uint idx, [NativeTypeName("REFIID")] Guid* iid, void** ppvObject);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcContainerReflection* pThis = &this)
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
        fixed (IDxcContainerReflection* pThis = &this)
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
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IDxcBlob* pContainer)
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>((IntPtr)(lpVtbl[5]))(pThis, pContainer);
        }
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.GetPartCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPartCount([NativeTypeName("UINT32 *")] uint* pResult)
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPartCount>((IntPtr)(lpVtbl[6]))(pThis, pResult);
        }
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.GetPartKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPartKind([NativeTypeName("UINT32")] uint idx, [NativeTypeName("UINT32 *")] uint* pResult)
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPartKind>((IntPtr)(lpVtbl[7]))(pThis, idx, pResult);
        }
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.GetPartContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPartContent([NativeTypeName("UINT32")] uint idx, IDxcBlob** ppResult)
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPartContent>((IntPtr)(lpVtbl[8]))(pThis, idx, ppResult);
        }
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.FindFirstPartKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindFirstPartKind([NativeTypeName("UINT32")] uint kind, [NativeTypeName("UINT32 *")] uint* pResult)
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindFirstPartKind>((IntPtr)(lpVtbl[9]))(pThis, kind, pResult);
        }
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.GetPartReflection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPartReflection([NativeTypeName("UINT32")] uint idx, [NativeTypeName("REFIID")] Guid* iid, void** ppvObject)
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPartReflection>((IntPtr)(lpVtbl[10]))(pThis, idx, iid, ppvObject);
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

        [NativeTypeName("HRESULT (IDxcBlob *)")]
        public IntPtr Load;

        [NativeTypeName("HRESULT (UINT32 *)")]
        public IntPtr GetPartCount;

        [NativeTypeName("HRESULT (UINT32, UINT32 *)")]
        public IntPtr GetPartKind;

        [NativeTypeName("HRESULT (UINT32, IDxcBlob **)")]
        public IntPtr GetPartContent;

        [NativeTypeName("HRESULT (UINT32, UINT32 *)")]
        public IntPtr FindFirstPartKind;

        [NativeTypeName("HRESULT (UINT32, REFIID, void **)")]
        public IntPtr GetPartReflection;
    }
}
