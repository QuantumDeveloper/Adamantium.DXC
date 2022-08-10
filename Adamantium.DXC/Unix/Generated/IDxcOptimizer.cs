using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer"]/*' />
[NativeTypeName("struct IDxcOptimizer : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcOptimizer
{
    public void** lpVtbl;

    internal IUnknown Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcOptimizer* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcOptimizer* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcOptimizer* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcOptimizer* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetAvailablePassCount(IDxcOptimizer* pThis, [NativeTypeName("UINT32 *")] uint* pCount);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetAvailablePass(IDxcOptimizer* pThis, [NativeTypeName("UINT32")] uint index, IDxcOptimizerPass** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _RunOptimizer(IDxcOptimizer* pThis, IDxcBlob* pBlob, [NativeTypeName("LPCWSTR *")] uint** ppOptions, [NativeTypeName("UINT32")] uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcOptimizer* pThis = &this)
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
        fixed (IDxcOptimizer* pThis = &this)
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
        fixed (IDxcOptimizer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcOptimizer* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer.GetAvailablePassCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAvailablePassCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        fixed (IDxcOptimizer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAvailablePassCount>((IntPtr)(lpVtbl[5]))(pThis, pCount);
        }
    }

    /// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer.GetAvailablePass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAvailablePass([NativeTypeName("UINT32")] uint index, IDxcOptimizerPass** ppResult)
    {
        fixed (IDxcOptimizer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAvailablePass>((IntPtr)(lpVtbl[6]))(pThis, index, ppResult);
        }
    }

    /// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer.RunOptimizer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RunOptimizer(IDxcBlob* pBlob, [NativeTypeName("LPCWSTR *")] uint** ppOptions, [NativeTypeName("UINT32")] uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        fixed (IDxcOptimizer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_RunOptimizer>((IntPtr)(lpVtbl[7]))(pThis, pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
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

        [NativeTypeName("HRESULT (UINT32 *)")]
        public IntPtr GetAvailablePassCount;

        [NativeTypeName("HRESULT (UINT32, IDxcOptimizerPass **)")]
        public IntPtr GetAvailablePass;

        [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR *, UINT32, IDxcBlob **, IDxcBlobEncoding **)")]
        public IntPtr RunOptimizer;
    }
}
