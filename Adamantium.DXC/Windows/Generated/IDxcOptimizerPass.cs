using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

/// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass"]/*' />
[Guid("AE2CD79F-CC22-453F-9B6B-B124E7A5204C")]
[NativeTypeName("struct IDxcOptimizerPass : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcOptimizerPass
{
    public void** lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _QueryInterface(IDxcOptimizerPass* pThis, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _AddRef(IDxcOptimizerPass* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _Release(IDxcOptimizerPass* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetOptionName(IDxcOptimizerPass* pThis, [NativeTypeName("LPWSTR *")] ushort** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetDescription(IDxcOptimizerPass* pThis, [NativeTypeName("LPWSTR *")] ushort** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetOptionArgCount(IDxcOptimizerPass* pThis, [NativeTypeName("UINT32 *")] uint* pCount);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetOptionArgName(IDxcOptimizerPass* pThis, [NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetOptionArgDescription(IDxcOptimizerPass* pThis, [NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcOptimizerPass* pThis = &this)
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
        fixed (IDxcOptimizerPass* pThis = &this)
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
        fixed (IDxcOptimizerPass* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetOptionName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOptionName([NativeTypeName("LPWSTR *")] ushort** ppResult)
    {
        fixed (IDxcOptimizerPass* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOptionName>((IntPtr)(lpVtbl[3]))(pThis, ppResult);
        }
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDescription([NativeTypeName("LPWSTR *")] ushort** ppResult)
    {
        fixed (IDxcOptimizerPass* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDescription>((IntPtr)(lpVtbl[4]))(pThis, ppResult);
        }
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetOptionArgCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetOptionArgCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        fixed (IDxcOptimizerPass* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOptionArgCount>((IntPtr)(lpVtbl[5]))(pThis, pCount);
        }
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetOptionArgName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetOptionArgName([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult)
    {
        fixed (IDxcOptimizerPass* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOptionArgName>((IntPtr)(lpVtbl[6]))(pThis, argIndex, ppResult);
        }
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetOptionArgDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetOptionArgDescription([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult)
    {
        fixed (IDxcOptimizerPass* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOptionArgDescription>((IntPtr)(lpVtbl[7]))(pThis, argIndex, ppResult);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public IntPtr GetOptionName;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public IntPtr GetDescription;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public IntPtr GetOptionArgCount;

        [NativeTypeName("HRESULT (UINT32, LPWSTR *) __attribute__((stdcall))")]
        public IntPtr GetOptionArgName;

        [NativeTypeName("HRESULT (UINT32, LPWSTR *) __attribute__((stdcall))")]
        public IntPtr GetOptionArgDescription;
    }
}
