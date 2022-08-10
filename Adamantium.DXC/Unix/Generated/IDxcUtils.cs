using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils"]/*' />
[NativeTypeName("struct IDxcUtils : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcUtils
{
    public void** lpVtbl;

    internal IUnknown Base;

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _QueryInterface(IDxcUtils* pThis, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _AddRef(IDxcUtils* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ULONG")]
    public delegate UIntPtr _Release(IDxcUtils* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void _Dispose(IDxcUtils* pThis);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _CreateBlobFromBlob(IDxcUtils* pThis, IDxcBlob* pBlob, [NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint length, IDxcBlob** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _CreateBlobFromPinned(IDxcUtils* pThis, [NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, IDxcBlobEncoding** pBlobEncoding);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _MoveToBlob(IDxcUtils* pThis, [NativeTypeName("LPCVOID")] void* pData, IMalloc* pIMalloc, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, IDxcBlobEncoding** pBlobEncoding);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _CreateBlob(IDxcUtils* pThis, [NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, IDxcBlobEncoding** pBlobEncoding);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _LoadFile(IDxcUtils* pThis, [NativeTypeName("LPCWSTR")] uint* pFileName, [NativeTypeName("UINT32 *")] uint* pCodePage, IDxcBlobEncoding** pBlobEncoding);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _CreateReadOnlyStreamFromBlob(IDxcUtils* pThis, IDxcBlob* pBlob, IStream** ppStream);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _CreateDefaultIncludeHandler(IDxcUtils* pThis, IDxcIncludeHandler** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetBlobAsUtf8(IDxcUtils* pThis, IDxcBlob* pBlob, IDxcBlobUtf8** pBlobEncoding);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetBlobAsWide(IDxcUtils* pThis, IDxcBlob* pBlob, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** pBlobEncoding);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetDxilContainerPart(IDxcUtils* pThis, [NativeTypeName("const DxcBuffer *")] DxcBuffer* pShader, [NativeTypeName("UINT32")] uint DxcPart, void** ppPartData, [NativeTypeName("UINT32 *")] uint* pPartSizeInBytes);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _CreateReflection(IDxcUtils* pThis, [NativeTypeName("const DxcBuffer *")] DxcBuffer* pData, [NativeTypeName("REFIID")] Guid* iid, void** ppvReflection);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _BuildArguments(IDxcUtils* pThis, [NativeTypeName("LPCWSTR")] uint* pSourceName, [NativeTypeName("LPCWSTR")] uint* pEntryPoint, [NativeTypeName("LPCWSTR")] uint* pTargetProfile, [NativeTypeName("LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, IDxcCompilerArgs** ppArgs);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate HRESULT _GetPDBContents(IDxcUtils* pThis, IDxcBlob* pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcUtils* pThis = &this)
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
        fixed (IDxcUtils* pThis = &this)
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
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        fixed (IDxcUtils* pThis = &this)
        {
            Marshal.GetDelegateForFunctionPointer<_Dispose>((IntPtr)(lpVtbl[4]))(pThis);
        }
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.CreateBlobFromBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateBlobFromBlob(IDxcBlob* pBlob, [NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint length, IDxcBlob** ppResult)
    {
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlobFromBlob>((IntPtr)(lpVtbl[5]))(pThis, pBlob, offset, length, ppResult);
        }
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.CreateBlobFromPinned"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateBlobFromPinned([NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlobFromPinned>((IntPtr)(lpVtbl[6]))(pThis, pData, size, codePage, pBlobEncoding);
        }
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.MoveToBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT MoveToBlob([NativeTypeName("LPCVOID")] void* pData, IMalloc* pIMalloc, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_MoveToBlob>((IntPtr)(lpVtbl[7]))(pThis, pData, pIMalloc, size, codePage, pBlobEncoding);
        }
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.CreateBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateBlob([NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBlob>((IntPtr)(lpVtbl[8]))(pThis, pData, size, codePage, pBlobEncoding);
        }
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.LoadFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LoadFile([NativeTypeName("LPCWSTR")] uint* pFileName, [NativeTypeName("UINT32 *")] uint* pCodePage, IDxcBlobEncoding** pBlobEncoding)
    {
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_LoadFile>((IntPtr)(lpVtbl[9]))(pThis, pFileName, pCodePage, pBlobEncoding);
        }
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.CreateReadOnlyStreamFromBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateReadOnlyStreamFromBlob(IDxcBlob* pBlob, IStream** ppStream)
    {
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateReadOnlyStreamFromBlob>((IntPtr)(lpVtbl[10]))(pThis, pBlob, ppStream);
        }
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.CreateDefaultIncludeHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateDefaultIncludeHandler(IDxcIncludeHandler** ppResult)
    {
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateDefaultIncludeHandler>((IntPtr)(lpVtbl[11]))(pThis, ppResult);
        }
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.GetBlobAsUtf8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetBlobAsUtf8(IDxcBlob* pBlob, IDxcBlobUtf8** pBlobEncoding)
    {
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBlobAsUtf8>((IntPtr)(lpVtbl[12]))(pThis, pBlob, pBlobEncoding);
        }
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.GetBlobAsWide"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetBlobAsWide(IDxcBlob* pBlob, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** pBlobEncoding)
    {
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBlobAsWide>((IntPtr)(lpVtbl[13]))(pThis, pBlob, pBlobEncoding);
        }
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.GetDxilContainerPart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDxilContainerPart([NativeTypeName("const DxcBuffer *")] DxcBuffer* pShader, [NativeTypeName("UINT32")] uint DxcPart, void** ppPartData, [NativeTypeName("UINT32 *")] uint* pPartSizeInBytes)
    {
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDxilContainerPart>((IntPtr)(lpVtbl[14]))(pThis, pShader, DxcPart, ppPartData, pPartSizeInBytes);
        }
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.CreateReflection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateReflection([NativeTypeName("const DxcBuffer *")] DxcBuffer* pData, [NativeTypeName("REFIID")] Guid* iid, void** ppvReflection)
    {
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateReflection>((IntPtr)(lpVtbl[15]))(pThis, pData, iid, ppvReflection);
        }
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.BuildArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT BuildArguments([NativeTypeName("LPCWSTR")] uint* pSourceName, [NativeTypeName("LPCWSTR")] uint* pEntryPoint, [NativeTypeName("LPCWSTR")] uint* pTargetProfile, [NativeTypeName("LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_BuildArguments>((IntPtr)(lpVtbl[16]))(pThis, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
        }
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.GetPDBContents"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetPDBContents(IDxcBlob* pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer)
    {
        fixed (IDxcUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPDBContents>((IntPtr)(lpVtbl[17]))(pThis, pPDBBlob, ppHash, ppContainer);
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

        [NativeTypeName("HRESULT (IDxcBlob *, UINT32, UINT32, IDxcBlob **)")]
        public IntPtr CreateBlobFromBlob;

        [NativeTypeName("HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **)")]
        public IntPtr CreateBlobFromPinned;

        [NativeTypeName("HRESULT (LPCVOID, IMalloc *, UINT32, UINT32, IDxcBlobEncoding **)")]
        public IntPtr MoveToBlob;

        [NativeTypeName("HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **)")]
        public IntPtr CreateBlob;

        [NativeTypeName("HRESULT (LPCWSTR, UINT32 *, IDxcBlobEncoding **)")]
        public IntPtr LoadFile;

        [NativeTypeName("HRESULT (IDxcBlob *, IStream **)")]
        public IntPtr CreateReadOnlyStreamFromBlob;

        [NativeTypeName("HRESULT (IDxcIncludeHandler **)")]
        public IntPtr CreateDefaultIncludeHandler;

        [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobUtf8 **)")]
        public IntPtr GetBlobAsUtf8;

        [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobWide **)")]
        public IntPtr GetBlobAsWide;

        [NativeTypeName("HRESULT (const DxcBuffer *, UINT32, void **, UINT32 *)")]
        public IntPtr GetDxilContainerPart;

        [NativeTypeName("HRESULT (const DxcBuffer *, REFIID, void **)")]
        public IntPtr CreateReflection;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcCompilerArgs **)")]
        public IntPtr BuildArguments;

        [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlob **, IDxcBlob **)")]
        public IntPtr GetPDBContents;
    }
}
