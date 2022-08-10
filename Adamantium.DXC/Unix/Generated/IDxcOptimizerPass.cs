using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass"]/*' />
[NativeTypeName("struct IDxcOptimizerPass : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcOptimizerPass
{
    public void** lpVtbl;

    internal IUnknown Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcOptimizerPass* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcOptimizerPass* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcOptimizerPass* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcOptimizerPass* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetOptionName(IDxcOptimizerPass* pThis, [NativeTypeName("LPWSTR *")] uint** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetDescription(IDxcOptimizerPass* pThis, [NativeTypeName("LPWSTR *")] uint** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetOptionArgCount(IDxcOptimizerPass* pThis, [NativeTypeName("UINT32 *")] uint* pCount);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetOptionArgName(IDxcOptimizerPass* pThis, [NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] uint** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetOptionArgDescription(IDxcOptimizerPass* pThis, [NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] uint** ppResult);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
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
    public UIntPtr AddRef()
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
    public UIntPtr Release()
    {
        fixed (IDxcOptimizerPass* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcOptimizerPass* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetOptionName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetOptionName([NativeTypeName("LPWSTR *")] uint** ppResult)
    {
        fixed (IDxcOptimizerPass* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOptionName>((IntPtr)(lpVtbl[5]))(pThis, ppResult);
        }
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDescription([NativeTypeName("LPWSTR *")] uint** ppResult)
    {
        fixed (IDxcOptimizerPass* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDescription>((IntPtr)(lpVtbl[6]))(pThis, ppResult);
        }
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetOptionArgCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetOptionArgCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        fixed (IDxcOptimizerPass* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOptionArgCount>((IntPtr)(lpVtbl[7]))(pThis, pCount);
        }
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetOptionArgName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetOptionArgName([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] uint** ppResult)
    {
        fixed (IDxcOptimizerPass* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOptionArgName>((IntPtr)(lpVtbl[8]))(pThis, argIndex, ppResult);
        }
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetOptionArgDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetOptionArgDescription([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] uint** ppResult)
    {
        fixed (IDxcOptimizerPass* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetOptionArgDescription>((IntPtr)(lpVtbl[9]))(pThis, argIndex, ppResult);
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

        [NativeTypeName("HRESULT (LPWSTR *)")]
        public IntPtr GetOptionName;

        [NativeTypeName("HRESULT (LPWSTR *)")]
        public IntPtr GetDescription;

        [NativeTypeName("HRESULT (UINT32 *)")]
        public IntPtr GetOptionArgCount;

        [NativeTypeName("HRESULT (UINT32, LPWSTR *)")]
        public IntPtr GetOptionArgName;

        [NativeTypeName("HRESULT (UINT32, LPWSTR *)")]
        public IntPtr GetOptionArgDescription;
    }
}
