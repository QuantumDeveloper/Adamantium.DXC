using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcOptimizerPass" /> struct.</summary>
public static unsafe partial class IDxcOptimizerPassTests
{
    /// <summary>Validates that the <see cref="IDxcOptimizerPass" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcOptimizerPass>(), Is.EqualTo(sizeof(IDxcOptimizerPass)));
    }

    /// <summary>Validates that the <see cref="IDxcOptimizerPass" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcOptimizerPass).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcOptimizerPass" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcOptimizerPass), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcOptimizerPass), Is.EqualTo(4));
        }
    }
}