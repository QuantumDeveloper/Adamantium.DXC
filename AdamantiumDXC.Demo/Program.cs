// See https://aka.ms/new-console-template for more information

using Adamantium.DXC;

DxcCompiler compiler = new DxcCompiler();
compiler.CompileIntoSpirv("simpleVertex.hlsl");
compiler.Compile("simpleVertex.hlsl");