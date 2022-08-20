using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcBlob.xml' path='doc/member[@name="IDxcBlob"]/*' />
[NativeTypeName("struct IDxcBlob : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcBlob
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlob*, Guid*, void**, int>)(lpVtbl[0]))((IDxcBlob*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlob*, nuint>)(lpVtbl[1]))((IDxcBlob*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlob*, nuint>)(lpVtbl[2]))((IDxcBlob*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcBlob*, void>)(lpVtbl[4]))((IDxcBlob*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcBlob.xml' path='doc/member[@name="IDxcBlob.GetBufferPointer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointer()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlob*, void*>)(lpVtbl[5]))((IDxcBlob*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcBlob.xml' path='doc/member[@name="IDxcBlob.GetBufferSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlob*, nuint>)(lpVtbl[6]))((IDxcBlob*)Unsafe.AsPointer(ref this));
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcBlob*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlob*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlob*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcBlob*, void> Dispose;

        [NativeTypeName("LPVOID ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlob*, void*> GetBufferPointer;

        [NativeTypeName("SIZE_T ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlob*, nuint> GetBufferSize;
    }
}
