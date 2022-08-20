using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcBlobUtf16.xml' path='doc/member[@name="IDxcBlobUtf16"]/*' />
[NativeTypeName("struct IDxcBlobWide : IDxcBlobEncoding")]
[NativeInheritance("IDxcBlobEncoding")]
internal unsafe partial struct IDxcBlobUtf16
{
    public void** lpVtbl;

    internal IDxcBlobEncoding Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, Guid*, void**, int>)(lpVtbl[0]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, nuint>)(lpVtbl[1]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, nuint>)(lpVtbl[2]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, void>)(lpVtbl[4]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcBlob.GetBufferPointer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointer()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, void*>)(lpVtbl[5]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcBlob.GetBufferSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, nuint>)(lpVtbl[6]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcBlobEncoding.GetEncoding" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEncoding(BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, BOOL*, uint*, int>)(lpVtbl[7]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
    }

    /// <include file='IDxcBlobUtf16.xml' path='doc/member[@name="IDxcBlobUtf16.GetStringPointer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("LPCWSTR")]
    public uint* GetStringPointer()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, uint*>)(lpVtbl[8]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcBlobUtf16.xml' path='doc/member[@name="IDxcBlobUtf16.GetStringLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetStringLength()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, nuint>)(lpVtbl[9]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, void> Dispose;

        [NativeTypeName("LPVOID ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, void*> GetBufferPointer;

        [NativeTypeName("SIZE_T ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, nuint> GetBufferSize;

        [NativeTypeName("HRESULT (BOOL *, UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, BOOL*, uint*, int> GetEncoding;

        [NativeTypeName("LPCWSTR ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, uint*> GetStringPointer;

        [NativeTypeName("SIZE_T ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, nuint> GetStringLength;
    }
}
