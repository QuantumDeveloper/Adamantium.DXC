using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="DxcBuffer" /> struct.</summary>
public static unsafe partial class DxcBufferTests
{
    /// <summary>Validates that the <see cref="DxcBuffer" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxcBuffer>(), Is.EqualTo(sizeof(DxcBuffer)));
    }

    /// <summary>Validates that the <see cref="DxcBuffer" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxcBuffer).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DxcBuffer" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DxcBuffer), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(DxcBuffer), Is.EqualTo(12));
        }
    }
}
