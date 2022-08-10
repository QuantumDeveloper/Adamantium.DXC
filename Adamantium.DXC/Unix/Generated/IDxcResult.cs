using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult"]/*' />
[NativeTypeName("struct IDxcResult : IDxcOperationResult")]
[NativeInheritance("IDxcOperationResult")]
internal unsafe partial struct IDxcResult
{
    public void** lpVtbl;

    internal IDxcOperationResult Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcResult* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcResult* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcResult* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcResult* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetStatus(IDxcResult* pThis, HRESULT* pStatus);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetResult(IDxcResult* pThis, IDxcBlob** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetErrorBuffer(IDxcResult* pThis, IDxcBlobEncoding** ppErrors);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate BOOL _HasOutput(IDxcResult* pThis, DXC_OUT_KIND dxcOutKind);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetOutput(IDxcResult* pThis, DXC_OUT_KIND dxcOutKind, [NativeTypeName("REFIID")] Guid* iid, void** ppvObject, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppOutputName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("UINT32")]
    public delegate uint _GetNumOutputs(IDxcResult* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate DXC_OUT_KIND _GetOutputByIndex(IDxcResult* pThis, [NativeTypeName("UINT32")] uint Index);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate DXC_OUT_KIND _PrimaryOutput(IDxcResult* pThis);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
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
    public UIntPtr AddRef()
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
    public UIntPtr Release()
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcResult* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <inheritdoc cref="IDxcOperationResult.GetStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStatus(HRESULT* pStatus)
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStatus>((IntPtr)(lpVtbl[5]))(pThis, pStatus);
        }
    }

    /// <inheritdoc cref="IDxcOperationResult.GetResult" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetResult(IDxcBlob** ppResult)
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetResult>((IntPtr)(lpVtbl[6]))(pThis, ppResult);
        }
    }

    /// <inheritdoc cref="IDxcOperationResult.GetErrorBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetErrorBuffer(IDxcBlobEncoding** ppErrors)
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetErrorBuffer>((IntPtr)(lpVtbl[7]))(pThis, ppErrors);
        }
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.HasOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public BOOL HasOutput(DXC_OUT_KIND dxcOutKind)
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_HasOutput>((IntPtr)(lpVtbl[8]))(pThis, dxcOutKind);
        }
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetOutput(DXC_OUT_KIND dxcOutKind, [NativeTypeName("REFIID")] Guid* iid, void** ppvObject, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppOutputName)
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOutput>((IntPtr)(lpVtbl[9]))(pThis, dxcOutKind, iid, ppvObject, ppOutputName);
        }
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetNumOutputs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("UINT32")]
    public uint GetNumOutputs()
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumOutputs>((IntPtr)(lpVtbl[10]))(pThis);
        }
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetOutputByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DXC_OUT_KIND GetOutputByIndex([NativeTypeName("UINT32")] uint Index)
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOutputByIndex>((IntPtr)(lpVtbl[11]))(pThis, Index);
        }
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.PrimaryOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public DXC_OUT_KIND PrimaryOutput()
    {
        fixed (IDxcResult* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_PrimaryOutput>((IntPtr)(lpVtbl[12]))(pThis);
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

        [NativeTypeName("BOOL (DXC_OUT_KIND)")]
        public IntPtr HasOutput;

        [NativeTypeName("HRESULT (DXC_OUT_KIND, REFIID, void **, IDxcBlobWide **)")]
        public IntPtr GetOutput;

        [NativeTypeName("UINT32 ()")]
        public IntPtr GetNumOutputs;

        [NativeTypeName("DXC_OUT_KIND (UINT32)")]
        public IntPtr GetOutputByIndex;

        [NativeTypeName("DXC_OUT_KIND ()")]
        public IntPtr PrimaryOutput;
    }
}
