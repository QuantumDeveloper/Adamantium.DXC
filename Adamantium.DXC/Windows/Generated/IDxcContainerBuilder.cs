using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

/// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder"]/*' />
[Guid("334B1F50-2292-4B35-99A1-25588D8C17FE")]
[NativeTypeName("struct IDxcContainerBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcContainerBuilder
{
    public void** lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _QueryInterface(IDxcContainerBuilder* pThis, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _AddRef(IDxcContainerBuilder* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _Release(IDxcContainerBuilder* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _Load(IDxcContainerBuilder* pThis, IDxcBlob* pDxilContainerHeader);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _AddPart(IDxcContainerBuilder* pThis, [NativeTypeName("UINT32")] uint fourCC, IDxcBlob* pSource);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _RemovePart(IDxcContainerBuilder* pThis, [NativeTypeName("UINT32")] uint fourCC);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _SerializeContainer(IDxcContainerBuilder* pThis, IDxcOperationResult** ppResult);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
    public uint AddRef()
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
    public uint Release()
    {
        fixed (IDxcContainerBuilder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load(IDxcBlob* pDxilContainerHeader)
    {
        fixed (IDxcContainerBuilder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>((IntPtr)(lpVtbl[3]))(pThis, pDxilContainerHeader);
        }
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.AddPart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddPart([NativeTypeName("UINT32")] uint fourCC, IDxcBlob* pSource)
    {
        fixed (IDxcContainerBuilder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddPart>((IntPtr)(lpVtbl[4]))(pThis, fourCC, pSource);
        }
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.RemovePart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemovePart([NativeTypeName("UINT32")] uint fourCC)
    {
        fixed (IDxcContainerBuilder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemovePart>((IntPtr)(lpVtbl[5]))(pThis, fourCC);
        }
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.SerializeContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SerializeContainer(IDxcOperationResult** ppResult)
    {
        fixed (IDxcContainerBuilder* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_SerializeContainer>((IntPtr)(lpVtbl[6]))(pThis, ppResult);
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

        [NativeTypeName("HRESULT (IDxcBlob *) __attribute__((stdcall))")]
        public IntPtr Load;

        [NativeTypeName("HRESULT (UINT32, IDxcBlob *) __attribute__((stdcall))")]
        public IntPtr AddPart;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public IntPtr RemovePart;

        [NativeTypeName("HRESULT (IDxcOperationResult **) __attribute__((stdcall))")]
        public IntPtr SerializeContainer;
    }
}
