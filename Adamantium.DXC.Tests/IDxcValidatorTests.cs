using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcValidator" /> struct.</summary>
public static unsafe partial class IDxcValidatorTests
{
    /// <summary>Validates that the <see cref="IDxcValidator" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcValidator>(), Is.EqualTo(sizeof(IDxcValidator)));
    }

    /// <summary>Validates that the <see cref="IDxcValidator" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcValidator).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcValidator" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcValidator), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcValidator), Is.EqualTo(4));
        }
    }
}
