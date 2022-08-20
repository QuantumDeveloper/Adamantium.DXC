using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcVersionInfo3.xml' path='doc/member[@name="IDxcVersionInfo3"]/*' />
[NativeTypeName("struct IDxcVersionInfo3 : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcVersionInfo3
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, Guid*, void**, int>)(lpVtbl[0]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, nuint>)(lpVtbl[1]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, nuint>)(lpVtbl[2]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, void>)(lpVtbl[4]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcVersionInfo3.xml' path='doc/member[@name="IDxcVersionInfo3.GetCustomVersionString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCustomVersionString([NativeTypeName("char **")] sbyte** pVersionString)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, sbyte**, int>)(lpVtbl[5]))((IDxcVersionInfo3*)Unsafe.AsPointer(ref this), pVersionString);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, void> Dispose;

        [NativeTypeName("HRESULT (char **)")]
        public delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, sbyte**, int> GetCustomVersionString;
    }
}
