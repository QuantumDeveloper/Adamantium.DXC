using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcValidator2.xml' path='doc/member[@name="IDxcValidator2"]/*' />
[NativeTypeName("struct IDxcValidator2 : IDxcValidator")]
[NativeInheritance("IDxcValidator")]
internal unsafe partial struct IDxcValidator2
{
    public void** lpVtbl;

    internal IDxcValidator Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcValidator2* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcValidator2* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcValidator2* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcValidator2* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Validate(IDxcValidator2* pThis, IDxcBlob* pShader, [NativeTypeName("UINT32")] uint Flags, IDxcOperationResult** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _ValidateWithDebug(IDxcValidator2* pThis, IDxcBlob* pShader, [NativeTypeName("UINT32")] uint Flags, DxcBuffer* pOptDebugBitcode, IDxcOperationResult** ppResult);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcValidator2* pThis = &this)
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
        fixed (IDxcValidator2* pThis = &this)
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
        fixed (IDxcValidator2* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcValidator2* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <inheritdoc cref="IDxcValidator.Validate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Validate(IDxcBlob* pShader, [NativeTypeName("UINT32")] uint Flags, IDxcOperationResult** ppResult)
    {
        fixed (IDxcValidator2* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Validate>((IntPtr)(lpVtbl[5]))(pThis, pShader, Flags, ppResult);
        }
    }

    /// <include file='IDxcValidator2.xml' path='doc/member[@name="IDxcValidator2.ValidateWithDebug"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ValidateWithDebug(IDxcBlob* pShader, [NativeTypeName("UINT32")] uint Flags, DxcBuffer* pOptDebugBitcode, IDxcOperationResult** ppResult)
    {
        fixed (IDxcValidator2* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_ValidateWithDebug>((IntPtr)(lpVtbl[6]))(pThis, pShader, Flags, pOptDebugBitcode, ppResult);
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

        [NativeTypeName("HRESULT (IDxcBlob *, UINT32, IDxcOperationResult **)")]
        public IntPtr Validate;

        [NativeTypeName("HRESULT (IDxcBlob *, UINT32, DxcBuffer *, IDxcOperationResult **)")]
        public IntPtr ValidateWithDebug;
    }
}
