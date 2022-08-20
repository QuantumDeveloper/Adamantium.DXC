using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcOperationResult.xml' path='doc/member[@name="IDxcOperationResult"]/*' />
[NativeTypeName("struct IDxcOperationResult : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcOperationResult
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, Guid*, void**, int>)(lpVtbl[0]))((IDxcOperationResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, nuint>)(lpVtbl[1]))((IDxcOperationResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, nuint>)(lpVtbl[2]))((IDxcOperationResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, void>)(lpVtbl[4]))((IDxcOperationResult*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcOperationResult.xml' path='doc/member[@name="IDxcOperationResult.GetStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStatus(HRESULT* pStatus)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, HRESULT*, int>)(lpVtbl[5]))((IDxcOperationResult*)Unsafe.AsPointer(ref this), pStatus);
    }

    /// <include file='IDxcOperationResult.xml' path='doc/member[@name="IDxcOperationResult.GetResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetResult(IDxcBlob** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, IDxcBlob**, int>)(lpVtbl[6]))((IDxcOperationResult*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcOperationResult.xml' path='doc/member[@name="IDxcOperationResult.GetErrorBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetErrorBuffer(IDxcBlobEncoding** ppErrors)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, IDxcBlobEncoding**, int>)(lpVtbl[7]))((IDxcOperationResult*)Unsafe.AsPointer(ref this), ppErrors);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcOperationResult*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcOperationResult*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcOperationResult*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcOperationResult*, void> Dispose;

        [NativeTypeName("HRESULT (HRESULT *)")]
        public delegate* unmanaged[Cdecl]<IDxcOperationResult*, HRESULT*, int> GetStatus;

        [NativeTypeName("HRESULT (IDxcBlob **)")]
        public delegate* unmanaged[Cdecl]<IDxcOperationResult*, IDxcBlob**, int> GetResult;

        [NativeTypeName("HRESULT (IDxcBlobEncoding **)")]
        public delegate* unmanaged[Cdecl]<IDxcOperationResult*, IDxcBlobEncoding**, int> GetErrorBuffer;
    }
}
