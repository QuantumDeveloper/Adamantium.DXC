// See https://aka.ms/new-console-template for more information

using Adamantium.DXC;
using Adamantium.DXC.Windows;

//DxcCompiler compiler = new DxcCompiler();
//compiler.CompileIntoSpirv("simpleVertex.hlsl");
//compiler.Compile("simpleVertex.hlsl");
WindowsDxcCompiler compiler = new WindowsDxcCompiler();
compiler.CompileIntoSpirv("simpleVertex.hlsl");