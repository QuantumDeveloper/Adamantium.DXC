using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcVersionInfo2" /> struct.</summary>
public static unsafe partial class IDxcVersionInfo2Tests
{
    /// <summary>Validates that the <see cref="IDxcVersionInfo2" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcVersionInfo2>(), Is.EqualTo(sizeof(IDxcVersionInfo2)));
    }

    /// <summary>Validates that the <see cref="IDxcVersionInfo2" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcVersionInfo2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcVersionInfo2" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcVersionInfo2), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcVersionInfo2), Is.EqualTo(4));
        }
    }
}