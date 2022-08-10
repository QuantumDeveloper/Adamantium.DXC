using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows;

[UnmanagedFunctionPointer(CallingConvention.StdCall)]
internal unsafe delegate HRESULT DxcCreateInstanceProc([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
