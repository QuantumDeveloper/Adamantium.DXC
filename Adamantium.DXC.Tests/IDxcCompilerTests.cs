using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcCompiler" /> struct.</summary>
public static unsafe partial class IDxcCompilerTests
{
    /// <summary>Validates that the <see cref="IDxcCompiler" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcCompiler>(), Is.EqualTo(sizeof(IDxcCompiler)));
    }

    /// <summary>Validates that the <see cref="IDxcCompiler" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcCompiler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcCompiler" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcCompiler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcCompiler), Is.EqualTo(4));
        }
    }
}
