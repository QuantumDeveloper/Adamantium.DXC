using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

/// <include file='IDxcVersionInfo.xml' path='doc/member[@name="IDxcVersionInfo"]/*' />
[Guid("B04F5B50-2059-4F12-A8FF-A1E0CDE1CC7E")]
[NativeTypeName("struct IDxcVersionInfo : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcVersionInfo
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, Guid*, void**, int>)(lpVtbl[0]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint>)(lpVtbl[1]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint>)(lpVtbl[2]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcVersionInfo.xml' path='doc/member[@name="IDxcVersionInfo.GetVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetVersion([NativeTypeName("UINT32 *")] uint* pMajor, [NativeTypeName("UINT32 *")] uint* pMinor)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint*, uint*, int>)(lpVtbl[3]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pMajor, pMinor);
    }

    /// <include file='IDxcVersionInfo.xml' path='doc/member[@name="IDxcVersionInfo.GetFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFlags([NativeTypeName("UINT32 *")] uint* pFlags)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint*, int>)(lpVtbl[4]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pFlags);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcVersionInfo*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint> Release;

        [NativeTypeName("HRESULT (UINT32 *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint*, uint*, int> GetVersion;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint*, int> GetFlags;
    }
}
