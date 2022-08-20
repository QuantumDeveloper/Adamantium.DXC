using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcLinker.xml' path='doc/member[@name="IDxcLinker"]/*' />
[NativeTypeName("struct IDxcLinker : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcLinker
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcLinker*, Guid*, void**, int>)(lpVtbl[0]))((IDxcLinker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcLinker*, nuint>)(lpVtbl[1]))((IDxcLinker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcLinker*, nuint>)(lpVtbl[2]))((IDxcLinker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcLinker*, void>)(lpVtbl[4]))((IDxcLinker*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcLinker.xml' path='doc/member[@name="IDxcLinker.RegisterLibrary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterLibrary([NativeTypeName("LPCWSTR")] uint* pLibName, IDxcBlob* pLib)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcLinker*, uint*, IDxcBlob*, int>)(lpVtbl[5]))((IDxcLinker*)Unsafe.AsPointer(ref this), pLibName, pLib);
    }

    /// <include file='IDxcLinker.xml' path='doc/member[@name="IDxcLinker.Link"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Link([NativeTypeName("LPCWSTR")] uint* pEntryName, [NativeTypeName("LPCWSTR")] uint* pTargetProfile, [NativeTypeName("const LPCWSTR *")] uint** pLibNames, [NativeTypeName("UINT32")] uint libCount, [NativeTypeName("const LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount, IDxcOperationResult** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcLinker*, uint*, uint*, uint**, uint, uint**, uint, IDxcOperationResult**, int>)(lpVtbl[6]))((IDxcLinker*)Unsafe.AsPointer(ref this), pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcLinker*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcLinker*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcLinker*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcLinker*, void> Dispose;

        [NativeTypeName("HRESULT (LPCWSTR, IDxcBlob *)")]
        public delegate* unmanaged[Cdecl]<IDxcLinker*, uint*, IDxcBlob*, int> RegisterLibrary;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, const LPCWSTR *, UINT32, const LPCWSTR *, UINT32, IDxcOperationResult **)")]
        public delegate* unmanaged[Cdecl]<IDxcLinker*, uint*, uint*, uint**, uint, uint**, uint, IDxcOperationResult**, int> Link;
    }
}
