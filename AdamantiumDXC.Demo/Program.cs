// See https://aka.ms/new-console-template for more information

using Adamantium.DXC;
using AdamantiumVulkan.SPIRV.Reflection;

var compiler = DxcCompiler.Create();
var compilerOptions = new CompilerOptions();
compilerOptions.Add(CompilerArguments.AllResourcesBound);
compilerOptions.Add(CompilerArguments.SpvUseDxLayout);
compilerOptions.Add($"{CompilerArguments.SpvTargetEnv}vulkan1.1");
compilerOptions.Add($"{CompilerArguments.SpvExtension}SPV_GOOGLE_hlsl_functionality1");
compilerOptions.Add($"{CompilerArguments.SpvExtension}SPV_GOOGLE_user_type");
compilerOptions.Add(CompilerArguments.SpvReflect);

var result = compiler.CompileIntoSpirv(
    "simpleVertex.hlsl", 
    "LightVertexShader", 
    "vs_6_6", compilerOptions);

SpirvReflection reflection = new SpirvReflection(result.Bytecode);
var lst = new List<ResourceBindingKey>();
var reflectionResult = reflection.Disassemble(lst);
var buffer = reflectionResult.UniformBuffers[0];
var member = buffer.GetVariable(0);
var arraySize = member.GetArraySizeForDimension(0);
compiler.Dispose();
Console.WriteLine("compiled");