using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Adamantium.DXC.Windows;

/// <include file='CustomIncludeHandler.xml' path='doc/member[@name="CustomIncludeHandler"]/*' />
[Guid("7F61FC7D-950D-467F-B3E3-3C02FB49187C")]
[NativeTypeName("struct CustomIncludeHandler : IUnknown")]
[NativeInheritance("IUnknown")]
internal unsafe partial struct CustomIncludeHandlerWrapper
{
    public void** lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT QueryInterfaceDelegate(CustomIncludeHandlerWrapper* pThis, Guid* riid, void** ppvObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint AddRefDelegate(CustomIncludeHandlerWrapper* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint ReleaseDelegate(CustomIncludeHandlerWrapper* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate HRESULT LoadSourceDelegate(CustomIncludeHandlerWrapper* pThis, ushort* pFilename, IDxcBlob** ppIncludeSource);

    private static readonly QueryInterfaceDelegate QueryInterfaceWrapper = QueryInterface;
    
    private static readonly AddRefDelegate AddRefWrapper = AddRef;
    
    private static readonly ReleaseDelegate ReleaseWrapper = Release;
    
    private static readonly LoadSourceDelegate LoadSourceDelegateWrapper = LoadSource;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public static HRESULT QueryInterface(CustomIncludeHandlerWrapper* pThis, Guid* riid, void** ppvObject)
    {
        if (ppvObject is null)
        {
            return HRESULT.POINTER;
        }

        if (riid == IID.IUnknown ||
            riid == IID.IDxcIncludeHandler)
        {
            _ = Interlocked.Increment(ref pThis->referenceCount);

            *ppvObject = pThis;

            return HRESULT.OK;
        }

        *ppvObject = null;

        return HRESULT.NOINTERFACE;
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public static uint AddRef(CustomIncludeHandlerWrapper* pThis)
    {
        return (uint)Interlocked.Increment(ref pThis->referenceCount);
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public static uint Release(CustomIncludeHandlerWrapper* pThis)
    {
        uint referenceCount = (uint)Interlocked.Decrement(ref pThis->referenceCount);

        if (referenceCount == 0)
        {
            RuntimeHelpers.Free(pThis);
        }

        return referenceCount;
    }

    /// <include file='CustomIncludeHandler.xml' path='doc/member[@name="CustomIncludeHandler.LoadSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public static HRESULT LoadSource(CustomIncludeHandlerWrapper* pThis, ushort* pFilename, IDxcBlob** ppIncludeSource)
    {
        ComPtr<IDxcBlobEncoding> pEncoding = default;
        //var func = pThis->DelegateHandle.Target as Func<string, string>;
        var path = Marshal.PtrToStringAuto((IntPtr)pFilename);

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            path = path.Replace('/', '\\');
        }

        var normalizedFileNamePtr = Marshal.StringToHGlobalUni(path);

        
        //var sourceText = func(path);
        
        //var bytes = Encoding.UTF8.GetBytes(sourceText);

        HRESULT hr;
        //fixed (byte* ptr = bytes)
        {
            
            //hr = Utils->CreateBlob(ptr, (uint)bytes.Length, 0, pEncoding.GetAddressOf());
            hr = Utils->LoadFile((ushort*)normalizedFileNamePtr, (uint*)0, pEncoding.GetAddressOf());
        }

        *ppIncludeSource = (IDxcBlob*)pEncoding.Detach();

        return hr;
    }
    
    public static readonly void** Vtbl = InitVtbl();
    
    private static IDxcUtils* Utils;
    private static IDxcIncludeHandler* DefaultHandler;
    
    public volatile int referenceCount;
    private GCHandle DelegateHandle;

    public static void** InitVtbl()
    {
        void** lpVtbl = (void**)RuntimeHelpers.AllocateTypeAssociatedMemory(sizeof(void*) * 4);

        lpVtbl[0] = (void*)Marshal.GetFunctionPointerForDelegate(QueryInterfaceWrapper);
        lpVtbl[1] = (void*)Marshal.GetFunctionPointerForDelegate(AddRefWrapper);
        lpVtbl[2] = (void*)Marshal.GetFunctionPointerForDelegate(ReleaseWrapper);
        lpVtbl[3] = (void*)Marshal.GetFunctionPointerForDelegate(LoadSourceDelegateWrapper); 
        return lpVtbl;
    }

    public static void Create(
        IDxcIncludeHandler* defaultHandler,
        IDxcUtils* utils, 
        GCHandle handle,
        CustomIncludeHandlerWrapper** customIncludeHandler)
    {
        CustomIncludeHandlerWrapper* @this = (CustomIncludeHandlerWrapper*)RuntimeHelpers.Alloc((nuint)sizeof(CustomIncludeHandlerWrapper));

        DefaultHandler = defaultHandler;
        Utils = utils;
        @this->lpVtbl = Vtbl;
        @this->referenceCount = 1;
        @this->DelegateHandle = handle;
        
        *customIncludeHandler = @this;
    }
}
