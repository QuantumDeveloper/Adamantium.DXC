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
}