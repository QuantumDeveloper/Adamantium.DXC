using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcCompiler3" /> struct.</summary>
public static unsafe partial class IDxcCompiler3Tests
{
    /// <summary>Validates that the <see cref="IDxcCompiler3" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcCompiler3>(), Is.EqualTo(sizeof(IDxcCompiler3)));
    }

    /// <summary>Validates that the <see cref="IDxcCompiler3" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcCompiler3).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcCompiler3" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcCompiler3), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcCompiler3), Is.EqualTo(4));
        }
    }
}
