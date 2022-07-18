using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC;

/// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs"]/*' />
[Guid("73EFFE2A-70DC-45F8-9690-EFF64C02429D")]
[NativeTypeName("struct IDxcCompilerArgs : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcCompilerArgs
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Guid*, void**, int>)(lpVtbl[0]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)(lpVtbl[1]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)(lpVtbl[2]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.GetArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPCWSTR *")]
    public ushort** GetArguments()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, ushort**>)(lpVtbl[3]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public uint GetCount()
    {
        return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint>)(lpVtbl[4]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddArguments([NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, ushort**, uint, int>)(lpVtbl[5]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pArguments, argCount);
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddArgumentsUTF8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddArgumentsUTF8([NativeTypeName("LPCSTR *")] sbyte** pArguments, [NativeTypeName("UINT32")] uint argCount)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, sbyte**, uint, int>)(lpVtbl[6]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pArguments, argCount);
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddDefines"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddDefines([NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, DxcDefine*, uint, int>)(lpVtbl[7]))((IDxcCompilerArgs*)Unsafe.AsPointer(ref this), pDefines, defineCount);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint> Release;

        [NativeTypeName("LPCWSTR *() __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, ushort**> GetArguments;

        [NativeTypeName("UINT32 () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, uint> GetCount;

        [NativeTypeName("HRESULT (LPCWSTR *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, ushort**, uint, int> AddArguments;

        [NativeTypeName("HRESULT (LPCSTR *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, sbyte**, uint, int> AddArgumentsUTF8;

        [NativeTypeName("HRESULT (const DxcDefine *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IDxcCompilerArgs*, DxcDefine*, uint, int> AddDefines;
    }
}
