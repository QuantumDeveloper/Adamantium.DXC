using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IMalloc.xml' path='doc/member[@name="IMalloc"]/*' />
[NativeTypeName("struct IMalloc : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IMalloc
{
    public void** lpVtbl;

    internal IUnknown Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IMalloc* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IMalloc* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IMalloc* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IMalloc* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* _Alloc(IMalloc* pThis, [NativeTypeName("size_t")] UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* _Realloc(IMalloc* pThis, void* ptr, [NativeTypeName("size_t")] UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Free(IMalloc* pThis, void* ptr);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IMalloc* pThis = &this)
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
        fixed (IMalloc* pThis = &this)
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
        fixed (IMalloc* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IMalloc* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <include file='IMalloc.xml' path='doc/member[@name="IMalloc.Alloc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void* Alloc([NativeTypeName("size_t")] UIntPtr size)
    {
        fixed (IMalloc* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Alloc>((IntPtr)(lpVtbl[5]))(pThis, size);
        }
    }

    /// <include file='IMalloc.xml' path='doc/member[@name="IMalloc.Realloc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void* Realloc(void* ptr, [NativeTypeName("size_t")] UIntPtr size)
    {
        fixed (IMalloc* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Realloc>((IntPtr)(lpVtbl[6]))(pThis, ptr, size);
        }
    }

    /// <include file='IMalloc.xml' path='doc/member[@name="IMalloc.Free"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void Free(void* ptr)
    {
        fixed (IMalloc* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Free>((IntPtr)(lpVtbl[7]))(pThis, ptr);
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

        [NativeTypeName("void *(size_t)")]
        public IntPtr Alloc;

        [NativeTypeName("void *(void *, size_t)")]
        public IntPtr Realloc;

        [NativeTypeName("void (void *)")]
        public IntPtr Free;
    }
}
