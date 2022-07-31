using System;

namespace Adamantium.DXC;

public class DxcCompilationResult
{
    public DxcCompilationResult()
    {
        
    }
    
    public byte[] Bytecode { get; internal set; }
    
    public bool HasErrors { get; internal set; }
    
    public string Name { get; internal set; }
    
    public string EntryPoint { get; internal set; }
    
    public string TargetProfile { get; set; }
    
    public string Errors { get; internal set; }
    
    public static implicit operator byte[](DxcCompilationResult result)
    {
        return result.Bytecode;
    }
}