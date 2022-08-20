using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

/// <include file='IDxcExtraOutputs.xml' path='doc/member[@name="IDxcExtraOutputs"]/*' />
[Guid("319B37A2-A5C2-494A-A5DE-4801B2FAF989")]
[NativeTypeName("struct IDxcExtraOutputs : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcExtraOutputs
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, Guid*, void**, int>)(lpVtbl[0]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)(lpVtbl[1]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)(lpVtbl[2]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcExtraOutputs.xml' path='doc/member[@name="IDxcExtraOutputs.GetOutputCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetOutputCount()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)(lpVtbl[3]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcExtraOutputs.xml' path='doc/member[@name="IDxcExtraOutputs.GetOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetOutput([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("const IID &")] Guid* iid, void** ppvObject, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppOutputType, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppOutputName)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)(lpVtbl[4]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this), uIndex, iid, ppvObject, ppOutputType, ppOutputName);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint> Release;

        [NativeTypeName("UINT32 () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint> GetOutputCount;

        [NativeTypeName("HRESULT (UINT32, const IID &, void **, IDxcBlobWide **, IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int> GetOutput;
    }
}
