using System;
using System.Runtime.InteropServices;
using Adamantium.DXC.Unix;
using Adamantium.DXC.Windows;

namespace Adamantium.DXC;

public class DxcCompiler
{
    public static IDxcCompilerPlatform Create()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return new WindowsDxcCompiler();
        }

        return new UnixDxcCompiler();
    }
    
    internal static void CheckResult(HRESULT hr, string filePath)
    {
        if (HRESULT.FAILED(hr))
        {
            if (HRESULT.INVALIDARG == hr)
            {
                throw new ArgumentException(
                    $"Cannot load {filePath}. Please, check correctness of file path, entry point and target profile");
            }
            else
            {
                throw new ShaderLoadException($"Cannot load {filePath}");
            }
        }
    }
}