using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

internal static unsafe partial class DxcInterop
{
    /// <include file='DxcInterop.xml' path='doc/member[@name="DxcInterop.SysFreeString"]/*' />
    [DllImport("libdxcompiler.so.3.7", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z13SysFreeStringPw", ExactSpelling = true)]
    public static extern void SysFreeString([NativeTypeName("BSTR")] uint* bstrString);

    /// <include file='DxcInterop.xml' path='doc/member[@name="DxcInterop.SysAllocStringLen"]/*' />
    [DllImport("libdxcompiler.so.3.7", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z17SysAllocStringLenPKwj", ExactSpelling = true)]
    [return: NativeTypeName("BSTR")]
    public static extern uint* SysAllocStringLen([NativeTypeName("const OLECHAR *")] uint* strIn, uint ui);

    /// <include file='DxcInterop.xml' path='doc/member[@name="DxcInterop.CPToLocale"]/*' />
    [DllImport("libdxcompiler.so.3.7", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z10CPToLocalej", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* CPToLocale([NativeTypeName("uint32_t")] uint CodePage);

    /// <include file='DxcInterop.xml' path='doc/member[@name="DxcInterop.DxcCreateInstance"]/*' />
    [DllImport("libdxcompiler.so.3.7", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern HRESULT DxcCreateInstance([NativeTypeName("REFCLSID")] Guid* rclsid, [NativeTypeName("REFIID")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

    /// <include file='DxcInterop.xml' path='doc/member[@name="DxcInterop.DxcCreateInstance2"]/*' />
    [DllImport("libdxcompiler.so.3.7", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern HRESULT DxcCreateInstance2(IMalloc* pMalloc, [NativeTypeName("REFCLSID")] Guid* rclsid, [NativeTypeName("REFIID")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
}
