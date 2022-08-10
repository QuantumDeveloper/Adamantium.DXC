using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

/// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection"]/*' />
[Guid("D2C21B26-8350-4BDC-976A-331CE6F4C54C")]
[NativeTypeName("struct IDxcContainerReflection : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcContainerReflection
{
    public void** lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _QueryInterface(IDxcContainerReflection* pThis, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _AddRef(IDxcContainerReflection* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _Release(IDxcContainerReflection* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _Load(IDxcContainerReflection* pThis, IDxcBlob* pContainer);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetPartCount(IDxcContainerReflection* pThis, [NativeTypeName("UINT32 *")] uint* pResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetPartKind(IDxcContainerReflection* pThis, [NativeTypeName("UINT32")] uint idx, [NativeTypeName("UINT32 *")] uint* pResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetPartContent(IDxcContainerReflection* pThis, [NativeTypeName("UINT32")] uint idx, IDxcBlob** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _FindFirstPartKind(IDxcContainerReflection* pThis, [NativeTypeName("UINT32")] uint kind, [NativeTypeName("UINT32 *")] uint* pResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetPartReflection(IDxcContainerReflection* pThis, [NativeTypeName("UINT32")] uint idx, [NativeTypeName("const IID &")] Guid* iid, void** ppvObject);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
    public uint AddRef()
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
    public uint Release()
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load(IDxcBlob* pContainer)
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>((IntPtr)(lpVtbl[3]))(pThis, pContainer);
        }
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.GetPartCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPartCount([NativeTypeName("UINT32 *")] uint* pResult)
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPartCount>((IntPtr)(lpVtbl[4]))(pThis, pResult);
        }
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.GetPartKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPartKind([NativeTypeName("UINT32")] uint idx, [NativeTypeName("UINT32 *")] uint* pResult)
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPartKind>((IntPtr)(lpVtbl[5]))(pThis, idx, pResult);
        }
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.GetPartContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPartContent([NativeTypeName("UINT32")] uint idx, IDxcBlob** ppResult)
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPartContent>((IntPtr)(lpVtbl[6]))(pThis, idx, ppResult);
        }
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.FindFirstPartKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindFirstPartKind([NativeTypeName("UINT32")] uint kind, [NativeTypeName("UINT32 *")] uint* pResult)
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_FindFirstPartKind>((IntPtr)(lpVtbl[7]))(pThis, kind, pResult);
        }
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.GetPartReflection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPartReflection([NativeTypeName("UINT32")] uint idx, [NativeTypeName("const IID &")] Guid* iid, void** ppvObject)
    {
        fixed (IDxcContainerReflection* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPartReflection>((IntPtr)(lpVtbl[8]))(pThis, idx, iid, ppvObject);
        }
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public IntPtr QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public IntPtr AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public IntPtr Release;

        [NativeTypeName("HRESULT (IDxcBlob *) __attribute__((stdcall))")]
        public IntPtr Load;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public IntPtr GetPartCount;

        [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((stdcall))")]
        public IntPtr GetPartKind;

        [NativeTypeName("HRESULT (UINT32, IDxcBlob **) __attribute__((stdcall))")]
        public IntPtr GetPartContent;

        [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((stdcall))")]
        public IntPtr FindFirstPartKind;

        [NativeTypeName("HRESULT (UINT32, const IID &, void **) __attribute__((stdcall))")]
        public IntPtr GetPartReflection;
    }
}
