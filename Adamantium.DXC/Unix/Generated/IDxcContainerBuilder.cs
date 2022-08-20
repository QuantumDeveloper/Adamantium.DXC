using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder"]/*' />
[NativeTypeName("struct IDxcContainerBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcContainerBuilder
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, nuint>)(lpVtbl[1]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, nuint>)(lpVtbl[2]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, void>)(lpVtbl[4]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IDxcBlob* pDxilContainerHeader)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, IDxcBlob*, int>)(lpVtbl[5]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), pDxilContainerHeader);
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.AddPart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddPart([NativeTypeName("UINT32")] uint fourCC, IDxcBlob* pSource)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, uint, IDxcBlob*, int>)(lpVtbl[6]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), fourCC, pSource);
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.RemovePart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemovePart([NativeTypeName("UINT32")] uint fourCC)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, uint, int>)(lpVtbl[7]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), fourCC);
    }

    /// <include file='IDxcContainerBuilder.xml' path='doc/member[@name="IDxcContainerBuilder.SerializeContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SerializeContainer(IDxcOperationResult** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, IDxcOperationResult**, int>)(lpVtbl[8]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), ppResult);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, void> Dispose;

        [NativeTypeName("HRESULT (IDxcBlob *)")]
        public delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, IDxcBlob*, int> Load;

        [NativeTypeName("HRESULT (UINT32, IDxcBlob *)")]
        public delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, uint, IDxcBlob*, int> AddPart;

        [NativeTypeName("HRESULT (UINT32)")]
        public delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, uint, int> RemovePart;

        [NativeTypeName("HRESULT (IDxcOperationResult **)")]
        public delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, IDxcOperationResult**, int> SerializeContainer;
    }
}
