using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal unsafe delegate HRESULT DxcCreateInstance2Proc(IMalloc* pMalloc, [NativeTypeName("REFCLSID")] Guid* rclsid, [NativeTypeName("REFIID")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
