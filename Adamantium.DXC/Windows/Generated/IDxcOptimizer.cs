using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

/// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer"]/*' />
[Guid("25740E2E-9CBA-401B-9119-4FB42F39F270")]
[NativeTypeName("struct IDxcOptimizer : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcOptimizer
{
    public void** lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _QueryInterface(IDxcOptimizer* pThis, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _AddRef(IDxcOptimizer* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _Release(IDxcOptimizer* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetAvailablePassCount(IDxcOptimizer* pThis, [NativeTypeName("UINT32 *")] uint* pCount);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetAvailablePass(IDxcOptimizer* pThis, [NativeTypeName("UINT32")] uint index, IDxcOptimizerPass** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _RunOptimizer(IDxcOptimizer* pThis, IDxcBlob* pBlob, [NativeTypeName("LPCWSTR *")] ushort** ppOptions, [NativeTypeName("UINT32")] uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
    public uint AddRef()
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
    public uint Release()
    {
        fixed (IDxcOptimizer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer.GetAvailablePassCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAvailablePassCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        fixed (IDxcOptimizer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAvailablePassCount>((IntPtr)(lpVtbl[3]))(pThis, pCount);
        }
    }

    /// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer.GetAvailablePass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAvailablePass([NativeTypeName("UINT32")] uint index, IDxcOptimizerPass** ppResult)
    {
        fixed (IDxcOptimizer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAvailablePass>((IntPtr)(lpVtbl[4]))(pThis, index, ppResult);
        }
    }

    /// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer.RunOptimizer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RunOptimizer(IDxcBlob* pBlob, [NativeTypeName("LPCWSTR *")] ushort** ppOptions, [NativeTypeName("UINT32")] uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        fixed (IDxcOptimizer* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_RunOptimizer>((IntPtr)(lpVtbl[5]))(pThis, pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public IntPtr GetAvailablePassCount;

        [NativeTypeName("HRESULT (UINT32, IDxcOptimizerPass **) __attribute__((stdcall))")]
        public IntPtr GetAvailablePass;

        [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR *, UINT32, IDxcBlob **, IDxcBlobEncoding **) __attribute__((stdcall))")]
        public IntPtr RunOptimizer;
    }
}
