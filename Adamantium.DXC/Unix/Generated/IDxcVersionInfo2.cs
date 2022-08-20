using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcVersionInfo2.xml' path='doc/member[@name="IDxcVersionInfo2"]/*' />
[NativeTypeName("struct IDxcVersionInfo2 : IDxcVersionInfo")]
[NativeInheritance("IDxcVersionInfo")]
internal unsafe partial struct IDxcVersionInfo2
{
    public void** lpVtbl;

    internal IDxcVersionInfo Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, nuint>)(lpVtbl[1]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, nuint>)(lpVtbl[2]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, void>)(lpVtbl[4]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcVersionInfo.GetVersion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetVersion([NativeTypeName("UINT32 *")] uint* pMajor, [NativeTypeName("UINT32 *")] uint* pMinor)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, uint*, int>)(lpVtbl[5]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this), pMajor, pMinor);
    }

    /// <inheritdoc cref="IDxcVersionInfo.GetFlags" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFlags([NativeTypeName("UINT32 *")] uint* pFlags)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, int>)(lpVtbl[6]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this), pFlags);
    }

    /// <include file='IDxcVersionInfo2.xml' path='doc/member[@name="IDxcVersionInfo2.GetCommitInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCommitInfo([NativeTypeName("UINT32 *")] uint* pCommitCount, [NativeTypeName("char **")] sbyte** pCommitHash)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, sbyte**, int>)(lpVtbl[7]))((IDxcVersionInfo2*)Unsafe.AsPointer(ref this), pCommitCount, pCommitHash);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, void> Dispose;

        [NativeTypeName("HRESULT (UINT32 *, UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, uint*, int> GetVersion;

        [NativeTypeName("HRESULT (UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, int> GetFlags;

        [NativeTypeName("HRESULT (UINT32 *, char **)")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, sbyte**, int> GetCommitInfo;
    }
}
