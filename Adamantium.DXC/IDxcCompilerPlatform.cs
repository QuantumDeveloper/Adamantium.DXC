using System;

namespace Adamantium.DXC;

public interface IDxcCompilerPlatform : IDisposable
{
    DxcCompilationResult CompileIntoSpirvFromFile(
        string filePath, 
        string entryPoint, 
        string targetProfile,
        CompilerOptions compilerOptions);
    
    DxcCompilationResult CompileIntoSpirvFromText(
        string sourceText, 
        string fileName,
        string entryPoint, 
        string targetProfile,
        CompilerOptions compilerOptions);
}