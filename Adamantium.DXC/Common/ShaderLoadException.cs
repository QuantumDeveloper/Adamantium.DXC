using System;

namespace Adamantium.DXC;

public class ShaderLoadException : Exception
{
    public ShaderLoadException(string message) : base(message)
    {
        
    }
}