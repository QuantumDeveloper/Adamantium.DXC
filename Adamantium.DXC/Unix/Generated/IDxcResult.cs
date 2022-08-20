using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult"]/*' />
[NativeTypeName("struct IDxcResult : IDxcOperationResult")]
[NativeInheritance("IDxcOperationResult")]
internal unsafe partial struct IDxcResult
{
    public void** lpVtbl;

    internal IDxcOperationResult Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcResult*, Guid*, void**, int>)(lpVtbl[0]))((IDxcResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcResult*, nuint>)(lpVtbl[1]))((IDxcResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcResult*, nuint>)(lpVtbl[2]))((IDxcResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcResult*, void>)(lpVtbl[4]))((IDxcResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcOperationResult.GetStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStatus(HRESULT* pStatus)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcResult*, HRESULT*, int>)(lpVtbl[5]))((IDxcResult*)Unsafe.AsPointer(ref this), pStatus);
    }

    /// <inheritdoc cref="IDxcOperationResult.GetResult" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetResult(IDxcBlob** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcResult*, IDxcBlob**, int>)(lpVtbl[6]))((IDxcResult*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <inheritdoc cref="IDxcOperationResult.GetErrorBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetErrorBuffer(IDxcBlobEncoding** ppErrors)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcResult*, IDxcBlobEncoding**, int>)(lpVtbl[7]))((IDxcResult*)Unsafe.AsPointer(ref this), ppErrors);
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.HasOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public BOOL HasOutput(DXC_OUT_KIND dxcOutKind)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcResult*, DXC_OUT_KIND, int>)(lpVtbl[8]))((IDxcResult*)Unsafe.AsPointer(ref this), dxcOutKind);
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetOutput(DXC_OUT_KIND dxcOutKind, [NativeTypeName("REFIID")] Guid* iid, void** ppvObject, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppOutputName)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcResult*, DXC_OUT_KIND, Guid*, void**, IDxcBlobUtf16**, int>)(lpVtbl[9]))((IDxcResult*)Unsafe.AsPointer(ref this), dxcOutKind, iid, ppvObject, ppOutputName);
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetNumOutputs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("UINT32")]
    public uint GetNumOutputs()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcResult*, uint>)(lpVtbl[10]))((IDxcResult*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetOutputByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DXC_OUT_KIND GetOutputByIndex([NativeTypeName("UINT32")] uint Index)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcResult*, uint, DXC_OUT_KIND>)(lpVtbl[11]))((IDxcResult*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.PrimaryOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public DXC_OUT_KIND PrimaryOutput()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcResult*, DXC_OUT_KIND>)(lpVtbl[12]))((IDxcResult*)Unsafe.AsPointer(ref this));
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcResult*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcResult*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcResult*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcResult*, void> Dispose;

        [NativeTypeName("HRESULT (HRESULT *)")]
        public delegate* unmanaged[Cdecl]<IDxcResult*, HRESULT*, int> GetStatus;

        [NativeTypeName("HRESULT (IDxcBlob **)")]
        public delegate* unmanaged[Cdecl]<IDxcResult*, IDxcBlob**, int> GetResult;

        [NativeTypeName("HRESULT (IDxcBlobEncoding **)")]
        public delegate* unmanaged[Cdecl]<IDxcResult*, IDxcBlobEncoding**, int> GetErrorBuffer;

        [NativeTypeName("BOOL (DXC_OUT_KIND)")]
        public delegate* unmanaged[Cdecl]<IDxcResult*, DXC_OUT_KIND, int> HasOutput;

        [NativeTypeName("HRESULT (DXC_OUT_KIND, REFIID, void **, IDxcBlobWide **)")]
        public delegate* unmanaged[Cdecl]<IDxcResult*, DXC_OUT_KIND, Guid*, void**, IDxcBlobUtf16**, int> GetOutput;

        [NativeTypeName("UINT32 ()")]
        public delegate* unmanaged[Cdecl]<IDxcResult*, uint> GetNumOutputs;

        [NativeTypeName("DXC_OUT_KIND (UINT32)")]
        public delegate* unmanaged[Cdecl]<IDxcResult*, uint, DXC_OUT_KIND> GetOutputByIndex;

        [NativeTypeName("DXC_OUT_KIND ()")]
        public delegate* unmanaged[Cdecl]<IDxcResult*, DXC_OUT_KIND> PrimaryOutput;
    }
}
