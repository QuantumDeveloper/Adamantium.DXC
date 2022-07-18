using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC;

/// <include file='IMalloc.xml' path='doc/member[@name="IMalloc"]/*' />
[Guid("00000002-0000-0000-C000-000000000046")]
[NativeTypeName("struct IMalloc : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMalloc
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Thiscall]<IMalloc*, Guid*, void**, int>)(lpVtbl[0]))((IMalloc*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Thiscall]<IMalloc*, uint>)(lpVtbl[1]))((IMalloc*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Thiscall]<IMalloc*, uint>)(lpVtbl[2]))((IMalloc*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void Dispose()
    {
        ((delegate* unmanaged[Thiscall]<IMalloc*, void>)(lpVtbl[3]))((IMalloc*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMalloc.xml' path='doc/member[@name="IMalloc.Alloc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void* Alloc([NativeTypeName("size_t")] nuint size)
    {
        return ((delegate* unmanaged[Thiscall]<IMalloc*, nuint, void*>)(lpVtbl[4]))((IMalloc*)Unsafe.AsPointer(ref this), size);
    }

    /// <include file='IMalloc.xml' path='doc/member[@name="IMalloc.Realloc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void* Realloc(void* ptr, [NativeTypeName("size_t")] nuint size)
    {
        return ((delegate* unmanaged[Thiscall]<IMalloc*, void*, nuint, void*>)(lpVtbl[5]))((IMalloc*)Unsafe.AsPointer(ref this), ptr, size);
    }

    /// <include file='IMalloc.xml' path='doc/member[@name="IMalloc.Free"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void Free(void* ptr)
    {
        ((delegate* unmanaged[Thiscall]<IMalloc*, void*, void>)(lpVtbl[6]))((IMalloc*)Unsafe.AsPointer(ref this), ptr);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Thiscall]<IMalloc*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Thiscall]<IMalloc*, uint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Thiscall]<IMalloc*, uint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Thiscall]<IMalloc*, void> Dispose;

        [NativeTypeName("void *(size_t)")]
        public delegate* unmanaged[Thiscall]<IMalloc*, nuint, void*> Alloc;

        [NativeTypeName("void *(void *, size_t)")]
        public delegate* unmanaged[Thiscall]<IMalloc*, void*, nuint, void*> Realloc;

        [NativeTypeName("void (void *)")]
        public delegate* unmanaged[Thiscall]<IMalloc*, void*, void> Free;
    }
}
