// See https://aka.ms/new-console-template for more information

using Adamantium.DXC;
using Adamantium.DXC.Unix;
using Adamantium.DXC.Windows;

var compiler = DxcCompiler.Create();
var result = compiler.CompileIntoSpirv(
    "simpleVertex.hlsl", 
    "LightVertexShader", 
    "vs_6_6",
    CompilerArguments.AllResourcesBound,
    CompilerArguments.SpvUseDxLayout,
    $"{CompilerArguments.SpvTargetEnv}vulkan1.1",
    $"{CompilerArguments.SpvExtension}SPV_GOOGLE_hlsl_functionality1",
    $"{CompilerArguments.SpvExtension}SPV_GOOGLE_user_type",
    CompilerArguments.SpvReflect);