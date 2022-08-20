using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcBlobEncoding.xml' path='doc/member[@name="IDxcBlobEncoding"]/*' />
[NativeTypeName("struct IDxcBlobEncoding : IDxcBlob")]
[NativeInheritance("IDxcBlob")]
internal unsafe partial struct IDxcBlobEncoding
{
    public void** lpVtbl;

    internal IDxcBlob Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, Guid*, void**, int>)(lpVtbl[0]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, nuint>)(lpVtbl[1]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, nuint>)(lpVtbl[2]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, void>)(lpVtbl[4]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcBlob.GetBufferPointer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointer()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, void*>)(lpVtbl[5]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcBlob.GetBufferSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, nuint>)(lpVtbl[6]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcBlobEncoding.xml' path='doc/member[@name="IDxcBlobEncoding.GetEncoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEncoding(BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, BOOL*, uint*, int>)(lpVtbl[7]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, void> Dispose;

        [NativeTypeName("LPVOID ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, void*> GetBufferPointer;

        [NativeTypeName("SIZE_T ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, nuint> GetBufferSize;

        [NativeTypeName("HRESULT (BOOL *, UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcBlobEncoding*, BOOL*, uint*, int> GetEncoding;
    }
}
