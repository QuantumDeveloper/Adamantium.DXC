using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcExtraOutputs.xml' path='doc/member[@name="IDxcExtraOutputs"]/*' />
[NativeTypeName("struct IDxcExtraOutputs : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcExtraOutputs
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, Guid*, void**, int>)(lpVtbl[0]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, nuint>)(lpVtbl[1]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, nuint>)(lpVtbl[2]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, void>)(lpVtbl[4]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcExtraOutputs.xml' path='doc/member[@name="IDxcExtraOutputs.GetOutputCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT32")]
    public uint GetOutputCount()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint>)(lpVtbl[5]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcExtraOutputs.xml' path='doc/member[@name="IDxcExtraOutputs.GetOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetOutput([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("REFIID")] Guid* iid, void** ppvObject, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppOutputType, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppOutputName)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)(lpVtbl[6]))((IDxcExtraOutputs*)Unsafe.AsPointer(ref this), uIndex, iid, ppvObject, ppOutputType, ppOutputName);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, void> Dispose;

        [NativeTypeName("UINT32 ()")]
        public delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint> GetOutputCount;

        [NativeTypeName("HRESULT (UINT32, REFIID, void **, IDxcBlobWide **, IDxcBlobWide **)")]
        public delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int> GetOutput;
    }
}
