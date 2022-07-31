using System;

namespace Adamantium.DXC;

public interface IDxcCompilerPlatform : IDisposable
{
    DXCCompileResult CompileIntoSpirv(string filePath, string entryPoint, string targetProfile, CompilerOptions compilerOptions);
}