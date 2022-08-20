using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcBlobUtf8.xml' path='doc/member[@name="IDxcBlobUtf8"]/*' />
[NativeTypeName("struct IDxcBlobUtf8 : IDxcBlobEncoding")]
[NativeInheritance("IDxcBlobEncoding")]
internal unsafe partial struct IDxcBlobUtf8
{
    public void** lpVtbl;

    internal IDxcBlobEncoding Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, Guid*, void**, int>)(lpVtbl[0]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, nuint>)(lpVtbl[1]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, nuint>)(lpVtbl[2]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, void>)(lpVtbl[4]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcBlob.GetBufferPointer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointer()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, void*>)(lpVtbl[5]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcBlob.GetBufferSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, nuint>)(lpVtbl[6]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcBlobEncoding.GetEncoding" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEncoding(BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, BOOL*, uint*, int>)(lpVtbl[7]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
    }

    /// <include file='IDxcBlobUtf8.xml' path='doc/member[@name="IDxcBlobUtf8.GetStringPointer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("LPCSTR")]
    public sbyte* GetStringPointer()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, sbyte*>)(lpVtbl[8]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcBlobUtf8.xml' path='doc/member[@name="IDxcBlobUtf8.GetStringLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetStringLength()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, nuint>)(lpVtbl[9]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, void> Dispose;

        [NativeTypeName("LPVOID ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, void*> GetBufferPointer;

        [NativeTypeName("SIZE_T ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, nuint> GetBufferSize;

        [NativeTypeName("HRESULT (BOOL *, UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, BOOL*, uint*, int> GetEncoding;

        [NativeTypeName("LPCSTR ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, sbyte*> GetStringPointer;

        [NativeTypeName("SIZE_T ()")]
        public delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, nuint> GetStringLength;
    }
}
