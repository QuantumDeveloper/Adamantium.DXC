using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

/// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils"]/*' />
[Guid("E6C9647E-9D6A-4C3B-B94C-524B5A6C343D")]
[NativeTypeName("struct IDxcPdbUtils : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct IDxcPdbUtils
{
    public void** lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _QueryInterface(IDxcPdbUtils* pThis, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _AddRef(IDxcPdbUtils* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("ULONG")]
    public delegate uint _Release(IDxcPdbUtils* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _Load(IDxcPdbUtils* pThis, IDxcBlob* pPdbOrDxil);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetSourceCount(IDxcPdbUtils* pThis, [NativeTypeName("UINT32 *")] uint* pCount);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetSource(IDxcPdbUtils* pThis, [NativeTypeName("UINT32")] uint uIndex, IDxcBlobEncoding** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetSourceName(IDxcPdbUtils* pThis, [NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetFlagCount(IDxcPdbUtils* pThis, [NativeTypeName("UINT32 *")] uint* pCount);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetFlag(IDxcPdbUtils* pThis, [NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetArgCount(IDxcPdbUtils* pThis, [NativeTypeName("UINT32 *")] uint* pCount);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetArg(IDxcPdbUtils* pThis, [NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetArgPairCount(IDxcPdbUtils* pThis, [NativeTypeName("UINT32 *")] uint* pCount);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetArgPair(IDxcPdbUtils* pThis, [NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pName, [NativeTypeName("BSTR *")] ushort** pValue);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetDefineCount(IDxcPdbUtils* pThis, [NativeTypeName("UINT32 *")] uint* pCount);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetDefine(IDxcPdbUtils* pThis, [NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetTargetProfile(IDxcPdbUtils* pThis, [NativeTypeName("BSTR *")] ushort** pResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetEntryPoint(IDxcPdbUtils* pThis, [NativeTypeName("BSTR *")] ushort** pResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetMainFileName(IDxcPdbUtils* pThis, [NativeTypeName("BSTR *")] ushort** pResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetHash(IDxcPdbUtils* pThis, IDxcBlob** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetName(IDxcPdbUtils* pThis, [NativeTypeName("BSTR *")] ushort** pResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate BOOL _IsFullPDB(IDxcPdbUtils* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetFullPDB(IDxcPdbUtils* pThis, IDxcBlob** ppFullPDB);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _GetVersionInfo(IDxcPdbUtils* pThis, IDxcVersionInfo** ppVersionInfo);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _SetCompiler(IDxcPdbUtils* pThis, IDxcCompiler3* pCompiler);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _CompileForFullPDB(IDxcPdbUtils* pThis, IDxcResult** ppResult);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _OverrideArgs(IDxcPdbUtils* pThis, DxcArgPair* pArgPairs, [NativeTypeName("UINT32")] uint uNumArgPairs);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT _OverrideRootSignature(IDxcPdbUtils* pThis, [NativeTypeName("const WCHAR *")] ushort* pRootSignature);

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>((IntPtr)(lpVtbl[0]))(pThis, riid, ppvObject);
        }
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>((IntPtr)(lpVtbl[1]))(pThis);
        }
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>((IntPtr)(lpVtbl[2]))(pThis);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load(IDxcBlob* pPdbOrDxil)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>((IntPtr)(lpVtbl[3]))(pThis, pPdbOrDxil);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetSourceCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSourceCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSourceCount>((IntPtr)(lpVtbl[4]))(pThis, pCount);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSource([NativeTypeName("UINT32")] uint uIndex, IDxcBlobEncoding** ppResult)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSource>((IntPtr)(lpVtbl[5]))(pThis, uIndex, ppResult);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetSourceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSourceName([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSourceName>((IntPtr)(lpVtbl[6]))(pThis, uIndex, pResult);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetFlagCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFlagCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFlagCount>((IntPtr)(lpVtbl[7]))(pThis, pCount);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetFlag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFlag([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFlag>((IntPtr)(lpVtbl[8]))(pThis, uIndex, pResult);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetArgCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetArgCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetArgCount>((IntPtr)(lpVtbl[9]))(pThis, pCount);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetArg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetArg([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetArg>((IntPtr)(lpVtbl[10]))(pThis, uIndex, pResult);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetArgPairCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetArgPairCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetArgPairCount>((IntPtr)(lpVtbl[11]))(pThis, pCount);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetArgPair"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetArgPair([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pName, [NativeTypeName("BSTR *")] ushort** pValue)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetArgPair>((IntPtr)(lpVtbl[12]))(pThis, uIndex, pName, pValue);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetDefineCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDefineCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDefineCount>((IntPtr)(lpVtbl[13]))(pThis, pCount);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetDefine"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDefine([NativeTypeName("UINT32")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pResult)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDefine>((IntPtr)(lpVtbl[14]))(pThis, uIndex, pResult);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetTargetProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetTargetProfile([NativeTypeName("BSTR *")] ushort** pResult)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTargetProfile>((IntPtr)(lpVtbl[15]))(pThis, pResult);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetEntryPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetEntryPoint([NativeTypeName("BSTR *")] ushort** pResult)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEntryPoint>((IntPtr)(lpVtbl[16]))(pThis, pResult);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetMainFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetMainFileName([NativeTypeName("BSTR *")] ushort** pResult)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMainFileName>((IntPtr)(lpVtbl[17]))(pThis, pResult);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetHash"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetHash(IDxcBlob** ppResult)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetHash>((IntPtr)(lpVtbl[18]))(pThis, ppResult);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetName([NativeTypeName("BSTR *")] ushort** pResult)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetName>((IntPtr)(lpVtbl[19]))(pThis, pResult);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.IsFullPDB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public BOOL IsFullPDB()
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsFullPDB>((IntPtr)(lpVtbl[20]))(pThis);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetFullPDB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFullPDB(IDxcBlob** ppFullPDB)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFullPDB>((IntPtr)(lpVtbl[21]))(pThis, ppFullPDB);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.GetVersionInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetVersionInfo(IDxcVersionInfo** ppVersionInfo)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVersionInfo>((IntPtr)(lpVtbl[22]))(pThis, ppVersionInfo);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.SetCompiler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetCompiler(IDxcCompiler3* pCompiler)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCompiler>((IntPtr)(lpVtbl[23]))(pThis, pCompiler);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.CompileForFullPDB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CompileForFullPDB(IDxcResult** ppResult)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_CompileForFullPDB>((IntPtr)(lpVtbl[24]))(pThis, ppResult);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.OverrideArgs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT OverrideArgs(DxcArgPair* pArgPairs, [NativeTypeName("UINT32")] uint uNumArgPairs)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_OverrideArgs>((IntPtr)(lpVtbl[25]))(pThis, pArgPairs, uNumArgPairs);
        }
    }

    /// <include file='IDxcPdbUtils.xml' path='doc/member[@name="IDxcPdbUtils.OverrideRootSignature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT OverrideRootSignature([NativeTypeName("const WCHAR *")] ushort* pRootSignature)
    {
        fixed (IDxcPdbUtils* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_OverrideRootSignature>((IntPtr)(lpVtbl[26]))(pThis, pRootSignature);
        }
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public IntPtr QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public IntPtr AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public IntPtr Release;

        [NativeTypeName("HRESULT (IDxcBlob *) __attribute__((stdcall))")]
        public IntPtr Load;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public IntPtr GetSourceCount;

        [NativeTypeName("HRESULT (UINT32, IDxcBlobEncoding **) __attribute__((stdcall))")]
        public IntPtr GetSource;

        [NativeTypeName("HRESULT (UINT32, BSTR *) __attribute__((stdcall))")]
        public IntPtr GetSourceName;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public IntPtr GetFlagCount;

        [NativeTypeName("HRESULT (UINT32, BSTR *) __attribute__((stdcall))")]
        public IntPtr GetFlag;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public IntPtr GetArgCount;

        [NativeTypeName("HRESULT (UINT32, BSTR *) __attribute__((stdcall))")]
        public IntPtr GetArg;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public IntPtr GetArgPairCount;

        [NativeTypeName("HRESULT (UINT32, BSTR *, BSTR *) __attribute__((stdcall))")]
        public IntPtr GetArgPair;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public IntPtr GetDefineCount;

        [NativeTypeName("HRESULT (UINT32, BSTR *) __attribute__((stdcall))")]
        public IntPtr GetDefine;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public IntPtr GetTargetProfile;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public IntPtr GetEntryPoint;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public IntPtr GetMainFileName;

        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public IntPtr GetHash;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public IntPtr GetName;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public IntPtr IsFullPDB;

        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public IntPtr GetFullPDB;

        [NativeTypeName("HRESULT (IDxcVersionInfo **) __attribute__((stdcall))")]
        public IntPtr GetVersionInfo;

        [NativeTypeName("HRESULT (IDxcCompiler3 *) __attribute__((stdcall))")]
        public IntPtr SetCompiler;

        [NativeTypeName("HRESULT (IDxcResult **) __attribute__((stdcall))")]
        public IntPtr CompileForFullPDB;

        [NativeTypeName("HRESULT (DxcArgPair *, UINT32) __attribute__((stdcall))")]
        public IntPtr OverrideArgs;

        [NativeTypeName("HRESULT (const WCHAR *) __attribute__((stdcall))")]
        public IntPtr OverrideRootSignature;
    }
}
