using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Adamantium.DXC;

/// <summary>
/// A polyfill type that mirrors some methods from <see cref="RuntimeHelpers"/> on .NET 5.
/// </summary>
internal static class RuntimeHelpers
{
    /// <summary>
    /// Allocates some memory tied to the lifetime of a specific type.
    /// </summary>
    /// <param name="size">The size in byte of the memory to allocate.</param>
    /// <returns>A pointer to the allocated memory.</returns>
    public static IntPtr AllocateTypeAssociatedMemory(int size) => Marshal.AllocHGlobal(size);
}