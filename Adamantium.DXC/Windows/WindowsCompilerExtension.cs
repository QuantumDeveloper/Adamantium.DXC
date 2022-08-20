using System;
using System.Runtime.CompilerServices;

namespace Adamantium.DXC.Windows;

internal static unsafe class WindowsCompilerExtension
{
    public static HRESULT Compile(IDxcCompiler3* compiler, DxcBuffer* pSource, ushort** pArguments, uint argCount, CustomIncludeHandlerWrapper* pIncludeHandler, Guid* riid, void** ppResult)
    {
        return ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, DxcBuffer*, ushort**, uint, CustomIncludeHandlerWrapper*, Guid*, void**, int>)(compiler->lpVtbl[3]))(compiler, pSource, pArguments, argCount, pIncludeHandler, riid, ppResult);
    }
}