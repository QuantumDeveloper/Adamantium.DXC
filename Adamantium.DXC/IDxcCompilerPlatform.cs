namespace Adamantium.DXC;

public interface IDxcCompilerPlatform
{
    DXCCompileResult CompileIntoSpirv(string filePath, string entryPoint, string targetProfile, params string[] compileArguments);
}