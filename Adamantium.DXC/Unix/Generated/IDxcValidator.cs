using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcValidator.xml' path='doc/member[@name="IDxcValidator"]/*' />
[NativeTypeName("struct IDxcValidator : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcValidator
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcValidator*, Guid*, void**, int>)(lpVtbl[0]))((IDxcValidator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcValidator*, nuint>)(lpVtbl[1]))((IDxcValidator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcValidator*, nuint>)(lpVtbl[2]))((IDxcValidator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcValidator*, void>)(lpVtbl[4]))((IDxcValidator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcValidator.xml' path='doc/member[@name="IDxcValidator.Validate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Validate(IDxcBlob* pShader, [NativeTypeName("UINT32")] uint Flags, IDxcOperationResult** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcValidator*, IDxcBlob*, uint, IDxcOperationResult**, int>)(lpVtbl[5]))((IDxcValidator*)Unsafe.AsPointer(ref this), pShader, Flags, ppResult);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcValidator*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcValidator*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcValidator*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcValidator*, void> Dispose;

        [NativeTypeName("HRESULT (IDxcBlob *, UINT32, IDxcOperationResult **)")]
        public delegate* unmanaged[Cdecl]<IDxcValidator*, IDxcBlob*, uint, IDxcOperationResult**, int> Validate;
    }
}
