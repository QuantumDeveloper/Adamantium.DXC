using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

internal static unsafe partial class DxcInterop
{
    /// <include file='DxcInterop.xml' path='doc/member[@name="DxcInterop.DxcCreateInstance"]/*' />
    [DllImport("dxcompiler", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
    public static extern HRESULT DxcCreateInstance([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

    /// <include file='DxcInterop.xml' path='doc/member[@name="DxcInterop.DxcCreateInstance2"]/*' />
    [DllImport("dxcompiler", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
    public static extern HRESULT DxcCreateInstance2(IMalloc* pMalloc, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
}
