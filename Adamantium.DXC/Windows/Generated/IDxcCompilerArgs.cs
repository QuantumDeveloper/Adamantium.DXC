using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

/// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs"]/*' />
[Guid("73EFFE2A-70DC-45F8-9690-EFF64C02429D")]
[NativeTypeName("struct IDxcCompilerArgs : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcCompilerArgs
{
    public void** lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _QueryInterface(IDxcCompilerArgs* pThis, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _AddRef(IDxcCompilerArgs* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _Release(IDxcCompilerArgs* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("LPCWSTR *")]
    public delegate ushort** _GetArguments(IDxcCompilerArgs* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("UINT32")]
    public delegate uint _GetCount(IDxcCompilerArgs* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _AddArguments(IDxcCompilerArgs* pThis, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _AddArgumentsUTF8(IDxcCompilerArgs* pThis, [NativeTypeName("LPCSTR *")] sbyte** pArguments, [NativeTypeName("UINT32")] uint argCount);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _AddDefines(IDxcCompilerArgs* pThis, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>((IntPtr)(lpVtbl[0]))(pThis, riid, ppvObject);
        }
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>((IntPtr)(lpVtbl[1]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.GetArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPCWSTR *")]
    public ushort** GetArguments()
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetArguments>((IntPtr)(lpVtbl[3]))(pThis);
        }
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public uint GetCount()
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCount>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddArguments([NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount)
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddArguments>((IntPtr)(lpVtbl[5]))(pThis, pArguments, argCount);
        }
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddArgumentsUTF8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddArgumentsUTF8([NativeTypeName("LPCSTR *")] sbyte** pArguments, [NativeTypeName("UINT32")] uint argCount)
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddArgumentsUTF8>((IntPtr)(lpVtbl[6]))(pThis, pArguments, argCount);
        }
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddDefines"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddDefines([NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount)
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddDefines>((IntPtr)(lpVtbl[7]))(pThis, pDefines, defineCount);
        }
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public IntPtr QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public IntPtr AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public IntPtr Release;

        [NativeTypeName("LPCWSTR *() __attribute__((stdcall))")]
        public IntPtr GetArguments;

        [NativeTypeName("UINT32 () __attribute__((stdcall))")]
        public IntPtr GetCount;

        [NativeTypeName("HRESULT (LPCWSTR *, UINT32) __attribute__((stdcall))")]
        public IntPtr AddArguments;

        [NativeTypeName("HRESULT (LPCSTR *, UINT32) __attribute__((stdcall))")]
        public IntPtr AddArgumentsUTF8;

        [NativeTypeName("HRESULT (const DxcDefine *, UINT32) __attribute__((stdcall))")]
        public IntPtr AddDefines;
    }
}
