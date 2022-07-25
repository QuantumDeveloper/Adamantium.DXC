using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcVersionInfo3" /> struct.</summary>
public static unsafe partial class IDxcVersionInfo3Tests
{
    /// <summary>Validates that the <see cref="IDxcVersionInfo3" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcVersionInfo3>(), Is.EqualTo(sizeof(IDxcVersionInfo3)));
    }

    /// <summary>Validates that the <see cref="IDxcVersionInfo3" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcVersionInfo3).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcVersionInfo3" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcVersionInfo3), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcVersionInfo3), Is.EqualTo(4));
        }
    }
}
