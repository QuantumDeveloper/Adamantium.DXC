using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC;

/// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult"]/*' />
[Guid("58346CDA-DDE7-4497-9461-6F87AF5E0659")]
[NativeTypeName("struct IDxcResult : IDxcOperationResult")]
[NativeInheritance("IDxcOperationResult")]
internal unsafe partial struct IDxcResult
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcResult*, Guid*, void**, int>)(lpVtbl[0]))((IDxcResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcResult*, uint>)(lpVtbl[1]))((IDxcResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcResult*, uint>)(lpVtbl[2]))((IDxcResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcOperationResult.GetStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStatus(HRESULT* pStatus)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcResult*, HRESULT*, int>)(lpVtbl[3]))((IDxcResult*)Unsafe.AsPointer(ref this), pStatus);
    }

    /// <inheritdoc cref="IDxcOperationResult.GetResult" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetResult(IDxcBlob** ppResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlob**, int>)(lpVtbl[4]))((IDxcResult*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <inheritdoc cref="IDxcOperationResult.GetErrorBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetErrorBuffer(IDxcBlobEncoding** ppErrors)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlobEncoding**, int>)(lpVtbl[5]))((IDxcResult*)Unsafe.AsPointer(ref this), ppErrors);
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.HasOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL HasOutput(DXC_OUT_KIND dxcOutKind)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcResult*, DXC_OUT_KIND, int>)(lpVtbl[6]))((IDxcResult*)Unsafe.AsPointer(ref this), dxcOutKind);
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetOutput(DXC_OUT_KIND dxcOutKind, [NativeTypeName("const IID &")] Guid* iid, void** ppvObject, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** ppOutputName)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcResult*, DXC_OUT_KIND, Guid*, void**, IDxcBlobUtf16**, int>)(lpVtbl[7]))((IDxcResult*)Unsafe.AsPointer(ref this), dxcOutKind, iid, ppvObject, ppOutputName);
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetNumOutputs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT32")]
    public uint GetNumOutputs()
    {
        return ((delegate* unmanaged[Thiscall]<IDxcResult*, uint>)(lpVtbl[8]))((IDxcResult*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.GetOutputByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public DXC_OUT_KIND GetOutputByIndex([NativeTypeName("UINT32")] uint Index)
    {
        return ((delegate* unmanaged[Thiscall]<IDxcResult*, uint, DXC_OUT_KIND>)(lpVtbl[9]))((IDxcResult*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='IDxcResult.xml' path='doc/member[@name="IDxcResult.PrimaryOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public DXC_OUT_KIND PrimaryOutput()
    {
        return ((delegate* unmanaged[Thiscall]<IDxcResult*, DXC_OUT_KIND>)(lpVtbl[10]))((IDxcResult*)Unsafe.AsPointer(ref this));
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcResult*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcResult*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcResult*, uint> Release;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcResult*, HRESULT*, int> GetStatus;

        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlob**, int> GetResult;

        [NativeTypeName("HRESULT (IDxcBlobEncoding **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlobEncoding**, int> GetErrorBuffer;

        [NativeTypeName("BOOL (DXC_OUT_KIND) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcResult*, DXC_OUT_KIND, int> HasOutput;

        [NativeTypeName("HRESULT (DXC_OUT_KIND, const IID &, void **, IDxcBlobWide **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcResult*, DXC_OUT_KIND, Guid*, void**, IDxcBlobUtf16**, int> GetOutput;

        [NativeTypeName("UINT32 ()")]
        public delegate* unmanaged[Thiscall]<IDxcResult*, uint> GetNumOutputs;

        [NativeTypeName("DXC_OUT_KIND (UINT32)")]
        public delegate* unmanaged[Thiscall]<IDxcResult*, uint, DXC_OUT_KIND> GetOutputByIndex;

        [NativeTypeName("DXC_OUT_KIND ()")]
        public delegate* unmanaged[Thiscall]<IDxcResult*, DXC_OUT_KIND> PrimaryOutput;
    }
}
