using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer"]/*' />
[NativeTypeName("struct IDxcOptimizer : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcOptimizer
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, Guid*, void**, int>)(lpVtbl[0]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, nuint>)(lpVtbl[1]))((IDxcOptimizer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, nuint>)(lpVtbl[2]))((IDxcOptimizer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, void>)(lpVtbl[4]))((IDxcOptimizer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer.GetAvailablePassCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAvailablePassCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, uint*, int>)(lpVtbl[5]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer.GetAvailablePass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAvailablePass([NativeTypeName("UINT32")] uint index, IDxcOptimizerPass** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)(lpVtbl[6]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), index, ppResult);
    }

    /// <include file='IDxcOptimizer.xml' path='doc/member[@name="IDxcOptimizer.RunOptimizer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RunOptimizer(IDxcBlob* pBlob, [NativeTypeName("LPCWSTR *")] uint** ppOptions, [NativeTypeName("UINT32")] uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, uint**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)(lpVtbl[7]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcOptimizer*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcOptimizer*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcOptimizer*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcOptimizer*, void> Dispose;

        [NativeTypeName("HRESULT (UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcOptimizer*, uint*, int> GetAvailablePassCount;

        [NativeTypeName("HRESULT (UINT32, IDxcOptimizerPass **)")]
        public delegate* unmanaged[Cdecl]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int> GetAvailablePass;

        [NativeTypeName("HRESULT (IDxcBlob *, LPCWSTR *, UINT32, IDxcBlob **, IDxcBlobEncoding **)")]
        public delegate* unmanaged[Cdecl]<IDxcOptimizer*, IDxcBlob*, uint**, uint, IDxcBlob**, IDxcBlobEncoding**, int> RunOptimizer;
    }
}
