using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC;

/// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass"]/*' />
[Guid("AE2CD79F-CC22-453F-9B6B-B124E7A5204C")]
[NativeTypeName("struct IDxcOptimizerPass : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcOptimizerPass
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)(lpVtbl[0]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint>)(lpVtbl[1]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint>)(lpVtbl[2]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetOptionName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOptionName([NativeTypeName("LPWSTR *")] ushort** ppResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, ushort**, int>)(lpVtbl[3]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDescription([NativeTypeName("LPWSTR *")] ushort** ppResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, ushort**, int>)(lpVtbl[4]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetOptionArgCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetOptionArgCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint*, int>)(lpVtbl[5]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetOptionArgName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetOptionArgName([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, ushort**, int>)(lpVtbl[6]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
    }

    /// <include file='IDxcOptimizerPass.xml' path='doc/member[@name="IDxcOptimizerPass.GetOptionArgDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetOptionArgDescription([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, ushort**, int>)(lpVtbl[7]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint> Release;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, ushort**, int> GetOptionName;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint*, int> GetOptionArgCount;

        [NativeTypeName("HRESULT (UINT32, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, ushort**, int> GetOptionArgName;

        [NativeTypeName("HRESULT (UINT32, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, ushort**, int> GetOptionArgDescription;
    }
}
