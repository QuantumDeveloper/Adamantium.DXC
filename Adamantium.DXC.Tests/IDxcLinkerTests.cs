using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcLinker" /> struct.</summary>
public static unsafe partial class IDxcLinkerTests
{
    /// <summary>Validates that the <see cref="IDxcLinker" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcLinker>(), Is.EqualTo(sizeof(IDxcLinker)));
    }

    /// <summary>Validates that the <see cref="IDxcLinker" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcLinker).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcLinker" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcLinker), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcLinker), Is.EqualTo(4));
        }
    }
}
