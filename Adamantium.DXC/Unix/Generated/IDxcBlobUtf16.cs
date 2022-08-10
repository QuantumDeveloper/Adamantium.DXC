using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcBlobUtf16.xml' path='doc/member[@name="IDxcBlobUtf16"]/*' />
[NativeTypeName("struct IDxcBlobWide : IDxcBlobEncoding")]
[NativeInheritance("IDxcBlobEncoding")]
internal unsafe partial struct IDxcBlobUtf16
{
    public void** lpVtbl;

    internal IDxcBlobEncoding Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcBlobUtf16* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcBlobUtf16* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcBlobUtf16* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcBlobUtf16* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("LPVOID")]
    public delegate void* _GetBufferPointer(IDxcBlobUtf16* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("SIZE_T")]
    public delegate nuint _GetBufferSize(IDxcBlobUtf16* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetEncoding(IDxcBlobUtf16* pThis, BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("LPCWSTR")]
    public delegate uint* _GetStringPointer(IDxcBlobUtf16* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("SIZE_T")]
    public delegate nuint _GetStringLength(IDxcBlobUtf16* pThis);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcBlobUtf16* pThis = &this)
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
        fixed (IDxcBlobUtf16* pThis = &this)
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
        fixed (IDxcBlobUtf16* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcBlobUtf16* pThis = &this)
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
        fixed (IDxcBlobUtf16* pThis = &this)
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
        fixed (IDxcBlobUtf16* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBufferSize>((IntPtr)(lpVtbl[6]))(pThis);
        }
    }

    /// <inheritdoc cref="IDxcBlobEncoding.GetEncoding" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEncoding(BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
    {
        fixed (IDxcBlobUtf16* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEncoding>((IntPtr)(lpVtbl[7]))(pThis, pKnown, pCodePage);
        }
    }

    /// <include file='IDxcBlobUtf16.xml' path='doc/member[@name="IDxcBlobUtf16.GetStringPointer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("LPCWSTR")]
    public uint* GetStringPointer()
    {
        fixed (IDxcBlobUtf16* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStringPointer>((IntPtr)(lpVtbl[8]))(pThis);
        }
    }

    /// <include file='IDxcBlobUtf16.xml' path='doc/member[@name="IDxcBlobUtf16.GetStringLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetStringLength()
    {
        fixed (IDxcBlobUtf16* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStringLength>((IntPtr)(lpVtbl[9]))(pThis);
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

        [NativeTypeName("LPCWSTR ()")]
        public IntPtr GetStringPointer;

        [NativeTypeName("SIZE_T ()")]
        public IntPtr GetStringLength;
    }
}
