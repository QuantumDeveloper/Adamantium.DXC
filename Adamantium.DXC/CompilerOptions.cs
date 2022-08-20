using System;
using System.Collections.Generic;

namespace Adamantium.DXC;

public class CompilerOptions
{
    private List<string> arguments;

    public CompilerOptions()
    {
        arguments = new List<string>();
    }

    public void Add(string opt)
    {
        arguments.Add(opt);
    }

    public string[] Get()
    {
        return arguments.ToArray();
    }
}