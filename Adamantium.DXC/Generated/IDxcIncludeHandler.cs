using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC;

/// <include file='IDxcIncludeHandler.xml' path='doc/member[@name="IDxcIncludeHandler"]/*' />
[Guid("7F61FC7D-950D-467F-B3E3-3C02FB49187C")]
[NativeTypeName("struct IDxcIncludeHandler : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcIncludeHandler
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, uint>)(lpVtbl[1]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, uint>)(lpVtbl[2]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcIncludeHandler.xml' path='doc/member[@name="IDxcIncludeHandler.LoadSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LoadSource([NativeTypeName("LPCWSTR")] ushort* pFilename, IDxcBlob** ppIncludeSource)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, ushort*, IDxcBlob**, int>)(lpVtbl[3]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this), pFilename, ppIncludeSource);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR, IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, ushort*, IDxcBlob**, int> LoadSource;
    }
}
