using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='ISequentialStream.xml' path='doc/member[@name="ISequentialStream"]/*' />
[NativeTypeName("struct ISequentialStream : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct ISequentialStream
{
    public void** lpVtbl;

    internal IUnknown Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(ISequentialStream* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(ISequentialStream* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(ISequentialStream* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(ISequentialStream* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Read(ISequentialStream* pThis, void* pv, [NativeTypeName("ULONG")] UIntPtr cb, [NativeTypeName("ULONG *")] UIntPtr* pcbRead);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _Write(ISequentialStream* pThis, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] UIntPtr cb, [NativeTypeName("ULONG *")] UIntPtr* pcbWritten);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (ISequentialStream* pThis = &this)
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
        fixed (ISequentialStream* pThis = &this)
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
        fixed (ISequentialStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (ISequentialStream* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <include file='ISequentialStream.xml' path='doc/member[@name="ISequentialStream.Read"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Read(void* pv, [NativeTypeName("ULONG")] UIntPtr cb, [NativeTypeName("ULONG *")] UIntPtr* pcbRead)
    {
        fixed (ISequentialStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Read>((IntPtr)(lpVtbl[5]))(pThis, pv, cb, pcbRead);
        }
    }

    /// <include file='ISequentialStream.xml' path='doc/member[@name="ISequentialStream.Write"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] UIntPtr cb, [NativeTypeName("ULONG *")] UIntPtr* pcbWritten)
    {
        fixed (ISequentialStream* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Write>((IntPtr)(lpVtbl[6]))(pThis, pv, cb, pcbWritten);
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

        [NativeTypeName("HRESULT (void *, ULONG, ULONG *)")]
        public IntPtr Read;

        [NativeTypeName("HRESULT (const void *, ULONG, ULONG *)")]
        public IntPtr Write;
    }
}
