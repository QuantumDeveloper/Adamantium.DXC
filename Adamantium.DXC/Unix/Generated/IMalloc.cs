using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IMalloc.xml' path='doc/member[@name="IMalloc"]/*' />
[NativeTypeName("struct IMalloc : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IMalloc
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IMalloc*, Guid*, void**, int>)(lpVtbl[0]))((IMalloc*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IMalloc*, nuint>)(lpVtbl[1]))((IMalloc*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IMalloc*, nuint>)(lpVtbl[2]))((IMalloc*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IMalloc*, void>)(lpVtbl[4]))((IMalloc*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMalloc.xml' path='doc/member[@name="IMalloc.Alloc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void* Alloc([NativeTypeName("size_t")] nuint size)
    {
        return ((delegate* unmanaged[Cdecl]<IMalloc*, nuint, void*>)(lpVtbl[5]))((IMalloc*)Unsafe.AsPointer(ref this), size);
    }

    /// <include file='IMalloc.xml' path='doc/member[@name="IMalloc.Realloc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void* Realloc(void* ptr, [NativeTypeName("size_t")] nuint size)
    {
        return ((delegate* unmanaged[Cdecl]<IMalloc*, void*, nuint, void*>)(lpVtbl[6]))((IMalloc*)Unsafe.AsPointer(ref this), ptr, size);
    }

    /// <include file='IMalloc.xml' path='doc/member[@name="IMalloc.Free"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void Free(void* ptr)
    {
        ((delegate* unmanaged[Cdecl]<IMalloc*, void*, void>)(lpVtbl[7]))((IMalloc*)Unsafe.AsPointer(ref this), ptr);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IMalloc*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IMalloc*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IMalloc*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IMalloc*, void> Dispose;

        [NativeTypeName("void *(size_t)")]
        public delegate* unmanaged[Cdecl]<IMalloc*, nuint, void*> Alloc;

        [NativeTypeName("void *(void *, size_t)")]
        public delegate* unmanaged[Cdecl]<IMalloc*, void*, nuint, void*> Realloc;

        [NativeTypeName("void (void *)")]
        public delegate* unmanaged[Cdecl]<IMalloc*, void*, void> Free;
    }
}
