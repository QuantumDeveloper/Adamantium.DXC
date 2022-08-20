using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Unix;

/// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils"]/*' />
[NativeTypeName("struct IDxcPdbUtils : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcPdbUtils
{
    public void** lpVtbl;

    internal IUnknown Base;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, Guid*, void**, int>)(lpVtbl[0]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public nuint AddRef()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, nuint>)(lpVtbl[1]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public nuint Release()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, nuint>)(lpVtbl[2]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Dispose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Dispose()
    {
        ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, void>)(lpVtbl[4]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IDxcBlob* pPdbOrDxil)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob*, int>)(lpVtbl[5]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pPdbOrDxil);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetSourceCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSourceCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)(lpVtbl[6]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSource([NativeTypeName("UINT32")] uint uIndex, IDxcBlobEncoding** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)(lpVtbl[7]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, ppResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetSourceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSourceName([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] uint** pResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, uint**, int>)(lpVtbl[8]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetFlagCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFlagCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)(lpVtbl[9]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetFlag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFlag([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] uint** pResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, uint**, int>)(lpVtbl[10]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetArgCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetArgCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)(lpVtbl[11]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetArg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetArg([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] uint** pResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, uint**, int>)(lpVtbl[12]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetArgPairCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetArgPairCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)(lpVtbl[13]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetArgPair"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetArgPair([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] uint** pName, [NativeTypeName("BSTR *")] uint** pValue)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, uint**, uint**, int>)(lpVtbl[14]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pName, pValue);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetDefineCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDefineCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)(lpVtbl[15]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetDefine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetDefine([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] uint** pResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, uint**, int>)(lpVtbl[16]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetTargetProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTargetProfile([NativeTypeName("BSTR *")] uint** pResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint**, int>)(lpVtbl[17]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetEntryPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetEntryPoint([NativeTypeName("BSTR *")] uint** pResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint**, int>)(lpVtbl[18]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetMainFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetMainFileName([NativeTypeName("BSTR *")] uint** pResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint**, int>)(lpVtbl[19]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetHash"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetHash(IDxcBlob** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob**, int>)(lpVtbl[20]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetName([NativeTypeName("BSTR *")] uint** pResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint**, int>)(lpVtbl[21]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.IsFullPDB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public BOOL IsFullPDB()
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, int>)(lpVtbl[22]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetFullPDB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetFullPDB(IDxcBlob** ppFullPDB)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob**, int>)(lpVtbl[23]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppFullPDB);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetVersionInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetVersionInfo(IDxcVersionInfo** ppVersionInfo)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcVersionInfo**, int>)(lpVtbl[24]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppVersionInfo);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.SetCompiler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetCompiler(IDxcCompiler3* pCompiler)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcCompiler3*, int>)(lpVtbl[25]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCompiler);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.CompileForFullPDB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CompileForFullPDB(IDxcResult** ppResult)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcResult**, int>)(lpVtbl[26]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.OverrideArgs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT OverrideArgs(DxcArgPair* pArgPairs, [NativeTypeName("UINT32")] uint uNumArgPairs)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, DxcArgPair*, uint, int>)(lpVtbl[27]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pArgPairs, uNumArgPairs);
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.OverrideRootSignature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT OverrideRootSignature([NativeTypeName("const WCHAR *")] uint* pRootSignature)
    {
        return ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)(lpVtbl[28]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pRootSignature);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (REFIID, void **)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, nuint> AddRef;

        [NativeTypeName("ULONG ()")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, nuint> Release;

        [NativeTypeName("void () noexcept")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, void> Dispose;

        [NativeTypeName("HRESULT (IDxcBlob *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob*, int> Load;

        [NativeTypeName("HRESULT (UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int> GetSourceCount;

        [NativeTypeName("HRESULT (UINT32, IDxcBlobEncoding **)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int> GetSource;

        [NativeTypeName("HRESULT (UINT32, BSTR *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, uint**, int> GetSourceName;

        [NativeTypeName("HRESULT (UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int> GetFlagCount;

        [NativeTypeName("HRESULT (UINT32, BSTR *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, uint**, int> GetFlag;

        [NativeTypeName("HRESULT (UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int> GetArgCount;

        [NativeTypeName("HRESULT (UINT32, BSTR *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, uint**, int> GetArg;

        [NativeTypeName("HRESULT (UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int> GetArgPairCount;

        [NativeTypeName("HRESULT (UINT32, BSTR *, BSTR *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, uint**, uint**, int> GetArgPair;

        [NativeTypeName("HRESULT (UINT32 *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int> GetDefineCount;

        [NativeTypeName("HRESULT (UINT32, BSTR *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, uint**, int> GetDefine;

        [NativeTypeName("HRESULT (BSTR *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint**, int> GetTargetProfile;

        [NativeTypeName("HRESULT (BSTR *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint**, int> GetEntryPoint;

        [NativeTypeName("HRESULT (BSTR *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint**, int> GetMainFileName;

        [NativeTypeName("HRESULT (IDxcBlob **)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob**, int> GetHash;

        [NativeTypeName("HRESULT (BSTR *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint**, int> GetName;

        [NativeTypeName("BOOL ()")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, int> IsFullPDB;

        [NativeTypeName("HRESULT (IDxcBlob **)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob**, int> GetFullPDB;

        [NativeTypeName("HRESULT (IDxcVersionInfo **)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcVersionInfo**, int> GetVersionInfo;

        [NativeTypeName("HRESULT (IDxcCompiler3 *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcCompiler3*, int> SetCompiler;

        [NativeTypeName("HRESULT (IDxcResult **)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcResult**, int> CompileForFullPDB;

        [NativeTypeName("HRESULT (DxcArgPair *, UINT32)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, DxcArgPair*, uint, int> OverrideArgs;

        [NativeTypeName("HRESULT (const WCHAR *)")]
        public delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int> OverrideRootSignature;
    }
}
