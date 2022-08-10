using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcBlobEncoding.xml' path='doc/member[@name="IDxcBlobEncoding"]/*' />
[NativeTypeName("struct IDxcBlobEncoding : IDxcBlob")]
[NativeInheritance("IDxcBlob")]
internal unsafe partial struct IDxcBlobEncoding
{
    public void** lpVtbl;

    internal IDxcBlob Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcBlobEncoding* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcBlobEncoding* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcBlobEncoding* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcBlobEncoding* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("LPVOID")]
    public delegate void* _GetBufferPointer(IDxcBlobEncoding* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("SIZE_T")]
    public delegate nuint _GetBufferSize(IDxcBlobEncoding* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetEncoding(IDxcBlobEncoding* pThis, BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcBlobEncoding* pThis = &this)
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
        fixed (IDxcBlobEncoding* pThis = &this)
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
        fixed (IDxcBlobEncoding* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcBlobEncoding* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <inheritdoc cref="IDxcBlob.GetBufferPointer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointer()
    {
        fixed (IDxcBlobEncoding* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBufferPointer>((IntPtr)(lpVtbl[5]))(pThis);
        }
    }

    /// <inheritdoc cref="IDxcBlob.GetBufferSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize()
    {
        fixed (IDxcBlobEncoding* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBufferSize>((IntPtr)(lpVtbl[6]))(pThis);
        }
    }

    /// <include file='IDxcBlobEncoding.xml' path='doc/member[@name="IDxcBlobEncoding.GetEncoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEncoding(BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
    {
        fixed (IDxcBlobEncoding* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEncoding>((IntPtr)(lpVtbl[7]))(pThis, pKnown, pCodePage);
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

        [NativeTypeName("LPVOID ()")]
        public IntPtr GetBufferPointer;

        [NativeTypeName("SIZE_T ()")]
        public IntPtr GetBufferSize;

        [NativeTypeName("HRESULT (BOOL *, UINT32 *)")]
        public IntPtr GetEncoding;
    }
}
