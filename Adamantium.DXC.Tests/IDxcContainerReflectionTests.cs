using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcContainerReflection" /> struct.</summary>
public static unsafe partial class IDxcContainerReflectionTests
{
    /// <summary>Validates that the <see cref="IDxcContainerReflection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcContainerReflection>(), Is.EqualTo(sizeof(IDxcContainerReflection)));
    }

    /// <summary>Validates that the <see cref="IDxcContainerReflection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcContainerReflection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcContainerReflection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcContainerReflection), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcContainerReflection), Is.EqualTo(4));
        }
    }
}
