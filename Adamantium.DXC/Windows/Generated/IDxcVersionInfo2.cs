using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC;

/// <include file='IDxcVersionInfo2.xml' path='doc/member[@name="IDxcVersionInfo2"]/*' />
[Guid("FB6904C4-42F0-4B62-9C46-983AF7DA7C83")]
[NativeTypeName("struct IDxcVersionInfo2 : IDxcVersionInfo")]
[NativeInheritance("IDxcVersionInfo")]
internal unsafe partial struct IDxcVersionInfo2
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint>)(lpVtbl[1]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint>)(lpVtbl[2]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcVersionInfo.GetVersion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetVersion([NativeTypeName("UINT32 *")] uint* pMajor, [NativeTypeName("UINT32 *")] uint* pMinor)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, uint*, int>)(lpVtbl[3]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this), pMajor, pMinor);
    }

    /// <inheritdoc cref="IDxcVersionInfo.GetFlags" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFlags([NativeTypeName("UINT32 *")] uint* pFlags)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, int>)(lpVtbl[4]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this), pFlags);
    }

    /// <include file='IDxcVersionInfo2.xml' path='doc/member[@name="IDxcVersionInfo2.GetCommitInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCommitInfo([NativeTypeName("UINT32 *")] uint* pCommitCount, [NativeTypeName("char **")] sbyte** pCommitHash)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, sbyte**, int>)(lpVtbl[5]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this), pCommitCount, pCommitHash);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint> Release;

        [NativeTypeName("HRESULT (UINT32 *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, uint*, int> GetVersion;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, int> GetFlags;

        [NativeTypeName("HRESULT (UINT32 *, char **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, sbyte**, int> GetCommitInfo;
    }
}
