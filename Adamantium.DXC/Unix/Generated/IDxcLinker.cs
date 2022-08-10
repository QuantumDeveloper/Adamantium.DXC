using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcLinker.xml' path='doc/member[@name="IDxcLinker"]/*' />
[NativeTypeName("struct IDxcLinker : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcLinker
{
    public void** lpVtbl;

    internal IUnknown Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcLinker* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcLinker* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcLinker* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcLinker* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _RegisterLibrary(IDxcLinker* pThis, [NativeTypeName("LPCWSTR")] uint* pLibName, IDxcBlob* pLib);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Link(IDxcLinker* pThis, [NativeTypeName("LPCWSTR")] uint* pEntryName, [NativeTypeName("LPCWSTR")] uint* pTargetProfile, [NativeTypeName("const LPCWSTR *")] uint** pLibNames, [NativeTypeName("UINT32")] uint libCount, [NativeTypeName("const LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount, IDxcOperationResult** ppResult);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcLinker* pThis = &this)
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
        fixed (IDxcLinker* pThis = &this)
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
        fixed (IDxcLinker* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcLinker* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <include file='IDxcLinker.xml' path='doc/member[@name="IDxcLinker.RegisterLibrary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterLibrary([NativeTypeName("LPCWSTR")] uint* pLibName, IDxcBlob* pLib)
    {
        fixed (IDxcLinker* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterLibrary>((IntPtr)(lpVtbl[5]))(pThis, pLibName, pLib);
        }
    }

    /// <include file='IDxcLinker.xml' path='doc/member[@name="IDxcLinker.Link"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Link([NativeTypeName("LPCWSTR")] uint* pEntryName, [NativeTypeName("LPCWSTR")] uint* pTargetProfile, [NativeTypeName("const LPCWSTR *")] uint** pLibNames, [NativeTypeName("UINT32")] uint libCount, [NativeTypeName("const LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount, IDxcOperationResult** ppResult)
    {
        fixed (IDxcLinker* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Link>((IntPtr)(lpVtbl[6]))(pThis, pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
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

        [NativeTypeName("HRESULT (LPCWSTR, IDxcBlob *)")]
        public IntPtr RegisterLibrary;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, const LPCWSTR *, UINT32, const LPCWSTR *, UINT32, IDxcOperationResult **)")]
        public IntPtr Link;
    }
}
