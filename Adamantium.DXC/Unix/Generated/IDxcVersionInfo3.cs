using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcVersionInfo3.xml' path='doc/member[@name="IDxcVersionInfo3"]/*' />
[NativeTypeName("struct IDxcVersionInfo3 : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcVersionInfo3
{
    public void** lpVtbl;

    internal IUnknown Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcVersionInfo3* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcVersionInfo3* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcVersionInfo3* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcVersionInfo3* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetCustomVersionString(IDxcVersionInfo3* pThis, [NativeTypeName("char **")] sbyte** pVersionString);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcVersionInfo3* pThis = &this)
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
        fixed (IDxcVersionInfo3* pThis = &this)
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
        fixed (IDxcVersionInfo3* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcVersionInfo3* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <include file='IDxcVersionInfo3.xml' path='doc/member[@name="IDxcVersionInfo3.GetCustomVersionString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCustomVersionString([NativeTypeName("char **")] sbyte** pVersionString)
    {
        fixed (IDxcVersionInfo3* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCustomVersionString>((IntPtr)(lpVtbl[5]))(pThis, pVersionString);
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

        [NativeTypeName("HRESULT (char **)")]
        public IntPtr GetCustomVersionString;
    }
}
