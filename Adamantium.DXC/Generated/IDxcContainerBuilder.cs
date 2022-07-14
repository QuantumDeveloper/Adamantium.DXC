using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC;

/// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder"]/*' />
[Guid("334B1F50-2292-4B35-99A1-25588D8C17FE")]
[NativeTypeName("struct IDxcContainerBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcContainerBuilder
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint>)(lpVtbl[1]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint>)(lpVtbl[2]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load(IDxcBlob* pDxilContainerHeader)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcBlob*, int>)(lpVtbl[3]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), pDxilContainerHeader);
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.AddPart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddPart([NativeTypeName("UINT32")] uint fourCC, IDxcBlob* pSource)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, IDxcBlob*, int>)(lpVtbl[4]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), fourCC, pSource);
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.RemovePart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemovePart([NativeTypeName("UINT32")] uint fourCC)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, int>)(lpVtbl[5]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), fourCC);
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.SerializeContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SerializeContainer(IDxcOperationResult** ppResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcOperationResult**, int>)(lpVtbl[6]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), ppResult);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint> Release;

        [NativeTypeName("HRESULT (IDxcBlob *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcBlob*, int> Load;

        [NativeTypeName("HRESULT (UINT32, IDxcBlob *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, IDxcBlob*, int> AddPart;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, int> RemovePart;

        [NativeTypeName("HRESULT (IDxcOperationResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcOperationResult**, int> SerializeContainer;
    }
}
