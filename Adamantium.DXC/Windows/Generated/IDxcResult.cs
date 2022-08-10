using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

/// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult"]/*' />
[Guid("58346CDA-DDE7-4497-9461-6F87AF5E0659")]
[NativeTypeName("struct IDxcResult : IDxcOperationResult")]
[NativeInheritance("IDxcOperationResult")]
internal unsafe partial struct IDxcResult
{
    public void** lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _QueryInterface(IDxcResult* pThis, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _AddRef(IDxcResult* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _Release(IDxcResult* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetStatus(IDxcResult* pThis, HRESULT* pStatus);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetResult(IDxcResult* pThis, IDxcBlob** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetErrorBuffer(IDxcResult* pThis, IDxcBlobEncoding** ppErrors);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate BOOL _HasOutput(IDxcResult* pThis, DXC_OUT_KIND dxcOutKind);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetOutput(IDxcResult* pThis, DXC_OUT_KIND dxcOutKind, [NativeTypeName("const IID &")] Guid* iid, void** ppvObject, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppOutputName);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("UINT32")]
    public delegate uint _GetNumOutputs(IDxcResult* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate DXC_OUT_KIND _GetOutputByIndex(IDxcResult* pThis, [NativeTypeName("UINT32")] uint Index);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate DXC_OUT_KIND _PrimaryOutput(IDxcResult* pThis);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcResult* pThis = &this)
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
        fixed (IDxcResult* pThis = &this)
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
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IDxcOperationResult.GetStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStatus(HRESULT* pStatus)
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStatus>((IntPtr)(lpVtbl[3]))(pThis, pStatus);
        }
    }

    /// <inheritdoc cref="IDxcOperationResult.GetResult" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetResult(IDxcBlob** ppResult)
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetResult>((IntPtr)(lpVtbl[4]))(pThis, ppResult);
        }
    }

    /// <inheritdoc cref="IDxcOperationResult.GetErrorBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetErrorBuffer(IDxcBlobEncoding** ppErrors)
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetErrorBuffer>((IntPtr)(lpVtbl[5]))(pThis, ppErrors);
        }
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.HasOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL HasOutput(DXC_OUT_KIND dxcOutKind)
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_HasOutput>((IntPtr)(lpVtbl[6]))(pThis, dxcOutKind);
        }
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetOutput(DXC_OUT_KIND dxcOutKind, [NativeTypeName("const IID &")] Guid* iid, void** ppvObject, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppOutputName)
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOutput>((IntPtr)(lpVtbl[7]))(pThis, dxcOutKind, iid, ppvObject, ppOutputName);
        }
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetNumOutputs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT32")]
    public uint GetNumOutputs()
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumOutputs>((IntPtr)(lpVtbl[8]))(pThis);
        }
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetOutputByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public DXC_OUT_KIND GetOutputByIndex([NativeTypeName("UINT32")] uint Index)
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOutputByIndex>((IntPtr)(lpVtbl[9]))(pThis, Index);
        }
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.PrimaryOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public DXC_OUT_KIND PrimaryOutput()
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_PrimaryOutput>((IntPtr)(lpVtbl[10]))(pThis);
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

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public IntPtr GetStatus;

        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public IntPtr GetResult;

        [NativeTypeName("HRESULT (IDxcBlobEncoding **) __attribute__((stdcall))")]
        public IntPtr GetErrorBuffer;

        [NativeTypeName("BOOL (DXC_OUT_KIND) __attribute__((stdcall))")]
        public IntPtr HasOutput;

        [NativeTypeName("HRESULT (DXC_OUT_KIND, const IID &, void **, IDxcBlobWide **) __attribute__((stdcall))")]
        public IntPtr GetOutput;

        [NativeTypeName("UINT32 ()")]
        public IntPtr GetNumOutputs;

        [NativeTypeName("DXC_OUT_KIND (UINT32)")]
        public IntPtr GetOutputByIndex;

        [NativeTypeName("DXC_OUT_KIND ()")]
        public IntPtr PrimaryOutput;
    }
}
