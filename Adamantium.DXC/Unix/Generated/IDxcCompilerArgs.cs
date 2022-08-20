using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs"]/*' />
[NativeTypeName("struct IDxcCompilerArgs : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcCompilerArgs
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, Guid*, void**, int>)(lpVtbl[0]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, nuint>)(lpVtbl[1]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, nuint>)(lpVtbl[2]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, void>)(lpVtbl[4]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.GetArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("LPCWSTR *")]
    public uint** GetArguments()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, uint**>)(lpVtbl[5]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("UINT32")]
    public uint GetCount()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, uint>)(lpVtbl[6]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddArguments([NativeTypeName("LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, uint**, uint, int>)(lpVtbl[7]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pArguments, argCount);
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddArgumentsUTF8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddArgumentsUTF8([NativeTypeName("LPCSTR *")] sbyte** pArguments, [NativeTypeName("UINT32")] uint argCount)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, sbyte**, uint, int>)(lpVtbl[8]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pArguments, argCount);
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddDefines"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddDefines([NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, DxcDefine*, uint, int>)(lpVtbl[9]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pDefines, defineCount);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, void> Dispose;

        [NativeTypeName("LPCWSTR *()")]
        public delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, uint**> GetArguments;

        [NativeTypeName("UINT32 ()")]
        public delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, uint> GetCount;

        [NativeTypeName("HRESULT (LPCWSTR *, UINT32)")]
        public delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, uint**, uint, int> AddArguments;

        [NativeTypeName("HRESULT (LPCSTR *, UINT32)")]
        public delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, sbyte**, uint, int> AddArgumentsUTF8;

        [NativeTypeName("HRESULT (const DxcDefine *, UINT32)")]
        public delegate* unmanaged[Cdecl]<IDxcCompilerArgs*, DxcDefine*, uint, int> AddDefines;
    }
}
