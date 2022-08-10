using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder"]/*' />
[NativeTypeName("struct IDxcContainerBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcContainerBuilder
{
    public void** lpVtbl;

    internal IUnknown Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcContainerBuilder* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcContainerBuilder* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcContainerBuilder* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcContainerBuilder* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Load(IDxcContainerBuilder* pThis, IDxcBlob* pDxilContainerHeader);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _AddPart(IDxcContainerBuilder* pThis, [NativeTypeName("UINT32")] uint fourCC, IDxcBlob* pSource);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _RemovePart(IDxcContainerBuilder* pThis, [NativeTypeName("UINT32")] uint fourCC);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _SerializeContainer(IDxcContainerBuilder* pThis, IDxcOperationResult** ppResult);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcContainerBuilder* pThis = &this)
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
        fixed (IDxcContainerBuilder* pThis = &this)
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
        fixed (IDxcContainerBuilder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcContainerBuilder* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IDxcBlob* pDxilContainerHeader)
    {
        fixed (IDxcContainerBuilder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>((IntPtr)(lpVtbl[5]))(pThis, pDxilContainerHeader);
        }
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.AddPart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddPart([NativeTypeName("UINT32")] uint fourCC, IDxcBlob* pSource)
    {
        fixed (IDxcContainerBuilder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddPart>((IntPtr)(lpVtbl[6]))(pThis, fourCC, pSource);
        }
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.RemovePart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemovePart([NativeTypeName("UINT32")] uint fourCC)
    {
        fixed (IDxcContainerBuilder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemovePart>((IntPtr)(lpVtbl[7]))(pThis, fourCC);
        }
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.SerializeContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SerializeContainer(IDxcOperationResult** ppResult)
    {
        fixed (IDxcContainerBuilder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_SerializeContainer>((IntPtr)(lpVtbl[8]))(pThis, ppResult);
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

        [NativeTypeName("HRESULT (IDxcBlob *)")]
        public IntPtr Load;

        [NativeTypeName("HRESULT (UINT32, IDxcBlob *)")]
        public IntPtr AddPart;

        [NativeTypeName("HRESULT (UINT32)")]
        public IntPtr RemovePart;

        [NativeTypeName("HRESULT (IDxcOperationResult **)")]
        public IntPtr SerializeContainer;
    }
}
