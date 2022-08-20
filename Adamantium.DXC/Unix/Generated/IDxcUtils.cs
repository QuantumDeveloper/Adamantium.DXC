using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils"]/*' />
[NativeTypeName("struct IDxcUtils : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcUtils
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, Guid*, void**, int>)(lpVtbl[0]))((IDxcUtils*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, nuint>)(lpVtbl[1]))((IDxcUtils*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, nuint>)(lpVtbl[2]))((IDxcUtils*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcUtils*, void>)(lpVtbl[4]))((IDxcUtils*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.CreateBlobFromBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateBlobFromBlob(IDxcBlob* pBlob, [NativeTypeName("UINT32")] uint offset, [NativeTypeName("UINT32")] uint length, IDxcBlob** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)(lpVtbl[5]))((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, offset, length, ppResult);
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.CreateBlobFromPinned"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateBlobFromPinned([NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)(lpVtbl[6]))((IDxcUtils*)Unsafe.AsPointer(ref this), pData, size, codePage, pBlobEncoding);
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.MoveToBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT MoveToBlob([NativeTypeName("LPCVOID")] void* pData, IMalloc* pIMalloc, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)(lpVtbl[7]))((IDxcUtils*)Unsafe.AsPointer(ref this), pData, pIMalloc, size, codePage, pBlobEncoding);
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.CreateBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateBlob([NativeTypeName("LPCVOID")] void* pData, [NativeTypeName("UINT32")] uint size, [NativeTypeName("UINT32")] uint codePage, IDxcBlobEncoding** pBlobEncoding)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)(lpVtbl[8]))((IDxcUtils*)Unsafe.AsPointer(ref this), pData, size, codePage, pBlobEncoding);
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.LoadFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LoadFile([NativeTypeName("LPCWSTR")] uint* pFileName, [NativeTypeName("UINT32 *")] uint* pCodePage, IDxcBlobEncoding** pBlobEncoding)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, uint*, uint*, IDxcBlobEncoding**, int>)(lpVtbl[9]))((IDxcUtils*)Unsafe.AsPointer(ref this), pFileName, pCodePage, pBlobEncoding);
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.CreateReadOnlyStreamFromBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateReadOnlyStreamFromBlob(IDxcBlob* pBlob, IStream** ppStream)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IStream**, int>)(lpVtbl[10]))((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, ppStream);
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.CreateDefaultIncludeHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateDefaultIncludeHandler(IDxcIncludeHandler** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcIncludeHandler**, int>)(lpVtbl[11]))((IDxcUtils*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.GetBlobAsUtf8"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetBlobAsUtf8(IDxcBlob* pBlob, IDxcBlobUtf8** pBlobEncoding)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)(lpVtbl[12]))((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.GetBlobAsWide"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetBlobAsWide(IDxcBlob* pBlob, [NativeTypeName("IDxcBlobWide **")] IDxcBlobUtf16** pBlobEncoding)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int>)(lpVtbl[13]))((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.GetDxilContainerPart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDxilContainerPart([NativeTypeName("const DxcBuffer *")] DxcBuffer* pShader, [NativeTypeName("UINT32")] uint DxcPart, void** ppPartData, [NativeTypeName("UINT32 *")] uint* pPartSizeInBytes)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, DxcBuffer*, uint, void**, uint*, int>)(lpVtbl[14]))((IDxcUtils*)Unsafe.AsPointer(ref this), pShader, DxcPart, ppPartData, pPartSizeInBytes);
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.CreateReflection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateReflection([NativeTypeName("const DxcBuffer *")] DxcBuffer* pData, [NativeTypeName("REFIID")] Guid* iid, void** ppvReflection)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, DxcBuffer*, Guid*, void**, int>)(lpVtbl[15]))((IDxcUtils*)Unsafe.AsPointer(ref this), pData, iid, ppvReflection);
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.BuildArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT BuildArguments([NativeTypeName("LPCWSTR")] uint* pSourceName, [NativeTypeName("LPCWSTR")] uint* pEntryPoint, [NativeTypeName("LPCWSTR")] uint* pTargetProfile, [NativeTypeName("LPCWSTR *")] uint** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, IDxcCompilerArgs** ppArgs)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, uint*, uint*, uint*, uint**, uint, DxcDefine*, uint, IDxcCompilerArgs**, int>)(lpVtbl[16]))((IDxcUtils*)Unsafe.AsPointer(ref this), pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
    }

    /// <include file='IDxcUtils.xml' path='doc/member[@name="IDxcUtils.GetPDBContents"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetPDBContents(IDxcBlob* pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)(lpVtbl[17]))((IDxcUtils*)Unsafe.AsPointer(ref this), pPDBBlob, ppHash, ppContainer);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, void> Dispose;

        [NativeTypeName("HRESULT (IDxcBlob *, UINT32, UINT32, IDxcBlob **)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int> CreateBlobFromBlob;

        [NativeTypeName("HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int> CreateBlobFromPinned;

        [NativeTypeName("HRESULT (LPCVOID, IMalloc *, UINT32, UINT32, IDxcBlobEncoding **)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int> MoveToBlob;

        [NativeTypeName("HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int> CreateBlob;

        [NativeTypeName("HRESULT (LPCWSTR, UINT32 *, IDxcBlobEncoding **)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, uint*, uint*, IDxcBlobEncoding**, int> LoadFile;

        [NativeTypeName("HRESULT (IDxcBlob *, IStream **)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IStream**, int> CreateReadOnlyStreamFromBlob;

        [NativeTypeName("HRESULT (IDxcIncludeHandler **)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcIncludeHandler**, int> CreateDefaultIncludeHandler;

        [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobUtf8 **)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int> GetBlobAsUtf8;

        [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobWide **)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int> GetBlobAsWide;

        [NativeTypeName("HRESULT (const DxcBuffer *, UINT32, void **, UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, DxcBuffer*, uint, void**, uint*, int> GetDxilContainerPart;

        [NativeTypeName("HRESULT (const DxcBuffer *, REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, DxcBuffer*, Guid*, void**, int> CreateReflection;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR *, UINT32, const DxcDefine *, UINT32, IDxcCompilerArgs **)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, uint*, uint*, uint*, uint**, uint, DxcDefine*, uint, IDxcCompilerArgs**, int> BuildArguments;

        [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlob **, IDxcBlob **)")]
        public delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int> GetPDBContents;
    }
}
