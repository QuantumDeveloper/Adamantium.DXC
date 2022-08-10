using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcCompiler3.xml' path='doc/member[@name="IDxcCompiler3"]/*' />
[NativeTypeName("struct IDxcCompiler3 : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcCompiler3
{
    public void** lpVtbl;

    internal IUnknown Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcCompiler3* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcCompiler3* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcCompiler3* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcCompiler3* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Compile(IDxcCompiler3* pThis, [NativeTypeName("const DxcBuffer *")] DxcBuffer* pSource, [NativeTypeName("LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount, IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("REFIID")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Disassemble(IDxcCompiler3* pThis, [NativeTypeName("const DxcBuffer *")] DxcBuffer* pObject, [NativeTypeName("REFIID")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppResult);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcCompiler3* pThis = &this)
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
        fixed (IDxcCompiler3* pThis = &this)
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
        fixed (IDxcCompiler3* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcCompiler3* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <include file='IDxcCompiler3.xml' path='doc/member[@name="IDxcCompiler3.Compile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Compile([NativeTypeName("const DxcBuffer *")] DxcBuffer* pSource, [NativeTypeName("LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount, IDxcIncludeHandler* pIncludeHandler, [NativeTypeName("REFIID")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppResult)
    {
        fixed (IDxcCompiler3* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Compile>((IntPtr)(lpVtbl[5]))(pThis, pSource, pArguments, argCount, pIncludeHandler, riid, ppResult);
        }
    }

    /// <include file='IDxcCompiler3.xml' path='doc/member[@name="IDxcCompiler3.Disassemble"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Disassemble([NativeTypeName("const DxcBuffer *")] DxcBuffer* pObject, [NativeTypeName("REFIID")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppResult)
    {
        fixed (IDxcCompiler3* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Disassemble>((IntPtr)(lpVtbl[6]))(pThis, pObject, riid, ppResult);
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

        [NativeTypeName("HRESULT (const DxcBuffer *, LPCWSTR *, UINT32, IDxcIncludeHandler *, REFIID, LPVOID *)")]
        public IntPtr Compile;

        [NativeTypeName("HRESULT (const DxcBuffer *, REFIID, LPVOID *)")]
        public IntPtr Disassemble;
    }
}
