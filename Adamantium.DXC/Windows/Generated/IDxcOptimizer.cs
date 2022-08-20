using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

/// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer"]/*' />
[Guid("25740E2E-9CBA-401B-9119-4FB42F39F270")]
[NativeTypeName("struct IDxcOptimizer : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcOptimizer
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)(lpVtbl[0]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint>)(lpVtbl[1]))((IDxcOptimizer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint>)(lpVtbl[2]))((IDxcOptimizer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer.GetAvailablePassCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAvailablePassCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint*, int>)(lpVtbl[3]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer.GetAvailablePass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAvailablePass([NativeTypeName("UINT32")] uint index, IDxcOptimizerPass** ppResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)(lpVtbl[4]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), index, ppResult);
    }

    /// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer.RunOptimizer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RunOptimizer(IDxcBlob* pBlob, [NativeTypeName("LPCWSTR *")] ushort** ppOptions, [NativeTypeName("UINT32")] uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, ushort**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)(lpVtbl[5]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint> Release;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint*, int> GetAvailablePassCount;

        [NativeTypeName("HRESULT (UINT32, IDxcOptimizerPass **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int> GetAvailablePass;

        [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR *, UINT32, IDxcBlob **, IDxcBlobEncoding **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, ushort**, uint, IDxcBlob**, IDxcBlobEncoding**, int> RunOptimizer;
    }
}
