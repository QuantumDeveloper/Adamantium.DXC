using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs"]/*' />
[NativeTypeName("struct IDxcCompilerArgs : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcCompilerArgs
{
    public void** lpVtbl;

    internal IUnknown Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcCompilerArgs* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcCompilerArgs* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcCompilerArgs* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcCompilerArgs* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("LPCWSTR *")]
    public delegate uint** _GetArguments(IDxcCompilerArgs* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("UINT32")]
    public delegate uint _GetCount(IDxcCompilerArgs* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _AddArguments(IDxcCompilerArgs* pThis, [NativeTypeName("LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _AddArgumentsUTF8(IDxcCompilerArgs* pThis, [NativeTypeName("LPCSTR *")] sbyte** pArguments, [NativeTypeName("UINT32")] uint argCount);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _AddDefines(IDxcCompilerArgs* pThis, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
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
    public UIntPtr AddRef()
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
    public UIntPtr Release()
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.GetArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("LPCWSTR *")]
    public uint** GetArguments()
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetArguments>((IntPtr)(lpVtbl[5]))(pThis);
        }
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("UINT32")]
    public uint GetCount()
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCount>((IntPtr)(lpVtbl[6]))(pThis);
        }
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddArguments([NativeTypeName("LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount)
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddArguments>((IntPtr)(lpVtbl[7]))(pThis, pArguments, argCount);
        }
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddArgumentsUTF8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddArgumentsUTF8([NativeTypeName("LPCSTR *")] sbyte** pArguments, [NativeTypeName("UINT32")] uint argCount)
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddArgumentsUTF8>((IntPtr)(lpVtbl[8]))(pThis, pArguments, argCount);
        }
    }

    /// <include file='IDxcCompilerArgs.xml' path='doc/member[@name="IDxcCompilerArgs.AddDefines"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddDefines([NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount)
    {
        fixed (IDxcCompilerArgs* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddDefines>((IntPtr)(lpVtbl[9]))(pThis, pDefines, defineCount);
        }
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public IntPtr QueryInterface;

        [NativeTypeName("ULONG ()")]
        public IntPtr AddRef;

        [NativeTypeName("ULONG ()")]
        public IntPtr Release;

        [NativeTypeName("void () noexcept")]
        public IntPtr Dispose;

        [NativeTypeName("LPCWSTR *()")]
        public IntPtr GetArguments;

        [NativeTypeName("UINT32 ()")]
        public IntPtr GetCount;

        [NativeTypeName("HRESULT (LPCWSTR *, UINT32)")]
        public IntPtr AddArguments;

        [NativeTypeName("HRESULT (LPCSTR *, UINT32)")]
        public IntPtr AddArgumentsUTF8;

        [NativeTypeName("HRESULT (const DxcDefine *, UINT32)")]
        public IntPtr AddDefines;
    }
}
