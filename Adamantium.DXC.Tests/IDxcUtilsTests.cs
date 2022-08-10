using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcUtils" /> struct.</summary>
public static unsafe partial class IDxcUtilsTests
{
    /// <summary>Validates that the <see cref="IDxcUtils" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcUtils>(), Is.EqualTo(sizeof(IDxcUtils)));
    }

    /// <summary>Validates that the <see cref="IDxcUtils" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcUtils).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcUtils" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcUtils), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcUtils), Is.EqualTo(4));
        }
    }
}
