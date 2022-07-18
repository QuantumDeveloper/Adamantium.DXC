using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC;

/// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection"]/*' />
[Guid("D2C21B26-8350-4BDC-976A-331CE6F4C54C")]
[NativeTypeName("struct IDxcContainerReflection : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcContainerReflection
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, Guid*, void**, int>)(lpVtbl[0]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint>)(lpVtbl[1]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint>)(lpVtbl[2]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load(IDxcBlob* pContainer)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, IDxcBlob*, int>)(lpVtbl[3]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), pContainer);
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.GetPartCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPartCount([NativeTypeName("UINT32 *")] uint* pResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint*, int>)(lpVtbl[4]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.GetPartKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPartKind([NativeTypeName("UINT32")] uint idx, [NativeTypeName("UINT32 *")] uint* pResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)(lpVtbl[5]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, pResult);
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.GetPartContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPartContent([NativeTypeName("UINT32")] uint idx, IDxcBlob** ppResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, IDxcBlob**, int>)(lpVtbl[6]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, ppResult);
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.FindFirstPartKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindFirstPartKind([NativeTypeName("UINT32")] uint kind, [NativeTypeName("UINT32 *")] uint* pResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)(lpVtbl[7]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), kind, pResult);
    }

    /// <include file='IDxcContainerReflection.xml' path='doc/member[@name="IDxcContainerReflection.GetPartReflection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPartReflection([NativeTypeName("UINT32")] uint idx, [NativeTypeName("const IID &")] Guid* iid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, Guid*, void**, int>)(lpVtbl[8]))((IDxcContainerReflection*)Unsafe.AsPointer(ref this), idx, iid, ppvObject);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerReflection*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint> Release;

        [NativeTypeName("HRESULT (IDxcBlob *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerReflection*, IDxcBlob*, int> Load;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint*, int> GetPartCount;

        [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int> GetPartKind;

        [NativeTypeName("HRESULT (UINT32, IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, IDxcBlob**, int> GetPartContent;

        [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int> FindFirstPartKind;

        [NativeTypeName("HRESULT (UINT32, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, Guid*, void**, int> GetPartReflection;
    }
}
