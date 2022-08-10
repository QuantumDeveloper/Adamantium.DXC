using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcContainerBuilder" /> struct.</summary>
public static unsafe partial class IDxcContainerBuilderTests
{
    /// <summary>Validates that the <see cref="IDxcContainerBuilder" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcContainerBuilder>(), Is.EqualTo(sizeof(IDxcContainerBuilder)));
    }

    /// <summary>Validates that the <see cref="IDxcContainerBuilder" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcContainerBuilder).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcContainerBuilder" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcContainerBuilder), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcContainerBuilder), Is.EqualTo(4));
        }
    }
}
