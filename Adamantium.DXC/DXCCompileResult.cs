using System;

namespace Adamantium.DXC;

public class DXCCompileResult
{
    public DXCCompileResult()
    {
        
    }
    
    public DXCCompileResult(IntPtr source, uint size)
    {
        Source = source;
        Size = size;
    }

    public IntPtr Source { get; internal set; }
    
    public uint Size { get; internal set; }
    
    public bool HasErrors { get; internal set; }
    
    public string Errors { get; internal set; }
}