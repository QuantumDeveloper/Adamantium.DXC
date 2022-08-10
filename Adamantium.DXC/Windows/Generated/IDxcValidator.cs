using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

/// <include file='IDxcValidator.xml' path='doc/member[@name="IDxcValidator"]/*' />
[Guid("A6E82BD2-1FD7-4826-9811-2857E797F49A")]
[NativeTypeName("struct IDxcValidator : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcValidator
{
    public void** lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _QueryInterface(IDxcValidator* pThis, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _AddRef(IDxcValidator* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _Release(IDxcValidator* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _Validate(IDxcValidator* pThis, IDxcBlob* pShader, [NativeTypeName("UINT32")] uint Flags, IDxcOperationResult** ppResult);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcValidator* pThis = &this)
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
        fixed (IDxcValidator* pThis = &this)
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
        fixed (IDxcValidator* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <include file='IDxcValidator.xml' path='doc/member[@name="IDxcValidator.Validate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Validate(IDxcBlob* pShader, [NativeTypeName("UINT32")] uint Flags, IDxcOperationResult** ppResult)
    {
        fixed (IDxcValidator* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Validate>((IntPtr)(lpVtbl[3]))(pThis, pShader, Flags, ppResult);
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

        [NativeTypeName("HRESULT (IDxcBlob *, UINT32, IDxcOperationResult **) __attribute__((stdcall))")]
        public IntPtr Validate;
    }
}
