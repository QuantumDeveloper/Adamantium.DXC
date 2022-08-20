using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Adamantium.DXC.IID;

namespace Adamantium.DXC.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcOptimizer" /> struct.</summary>
public static unsafe partial class IDxcOptimizerTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDxcOptimizer" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcOptimizer).GUID, Is.EqualTo(IID_IDxcOptimizer));
    }

    /// <summary>Validates that the <see cref="IDxcOptimizer" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcOptimizer>(), Is.EqualTo(sizeof(IDxcOptimizer)));
    }

    /// <summary>Validates that the <see cref="IDxcOptimizer" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcOptimizer).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcOptimizer" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcOptimizer), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcOptimizer), Is.EqualTo(4));
        }
    }
}
