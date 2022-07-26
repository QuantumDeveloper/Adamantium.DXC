using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

/// <include file='IDxcValidator2.xml' path='doc/member[@name="IDxcValidator2"]/*' />
[Guid("458E1FD1-B1B2-4750-A6E1-9C10F03BED92")]
[NativeTypeName("struct IDxcValidator2 : IDxcValidator")]
[NativeInheritance("IDxcValidator")]
internal unsafe partial struct IDxcValidator2
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)(lpVtbl[0]))((IDxcValidator2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcValidator2*, uint>)(lpVtbl[1]))((IDxcValidator2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcValidator2*, uint>)(lpVtbl[2]))((IDxcValidator2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDxcValidator.Validate" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Validate(IDxcBlob* pShader, [NativeTypeName("UINT32")] uint Flags, IDxcOperationResult** ppResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)(lpVtbl[3]))((IDxcValidator2*)Unsafe.AsPointer(ref this), pShader, Flags, ppResult);
    }

    /// <include file='IDxcValidator2.xml' path='doc/member[@name="IDxcValidator2.ValidateWithDebug"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ValidateWithDebug(IDxcBlob* pShader, [NativeTypeName("UINT32")] uint Flags, DxcBuffer* pOptDebugBitcode, IDxcOperationResult** ppResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, DxcBuffer*, IDxcOperationResult**, int>)(lpVtbl[4]))((IDxcValidator2*)Unsafe.AsPointer(ref this), pShader, Flags, pOptDebugBitcode, ppResult);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcValidator2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcValidator2*, uint> Release;

        [NativeTypeName("HRESULT (IDxcBlob *, UINT32, IDxcOperationResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int> Validate;

        [NativeTypeName("HRESULT (IDxcBlob *, UINT32, DxcBuffer *, IDxcOperationResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, DxcBuffer*, IDxcOperationResult**, int> ValidateWithDebug;
    }
}
