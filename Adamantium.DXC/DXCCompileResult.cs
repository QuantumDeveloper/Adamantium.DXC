using System;

namespace Adamantium.DXC;

public class DXCCompileResult
{
    public DXCCompileResult()
    {
        
    }
    
    public byte[] Bytecode { get; internal set; }
    
    public bool HasErrors { get; internal set; }
    
    public string Errors { get; internal set; }
}