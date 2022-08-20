using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DxcArgPair" /> struct.</summary>
public static unsafe partial class DxcArgPairTests
{
    /// <summary>Validates that the <see cref="DxcArgPair" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxcArgPair>(), Is.EqualTo(sizeof(DxcArgPair)));
    }

    /// <summary>Validates that the <see cref="DxcArgPair" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxcArgPair).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DxcArgPair" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DxcArgPair), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(DxcArgPair), Is.EqualTo(8));
        }
    }
}
