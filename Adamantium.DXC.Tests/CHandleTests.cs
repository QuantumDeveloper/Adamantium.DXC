using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="CHandle" /> struct.</summary>
public static unsafe partial class CHandleTests
{
    /// <summary>Validates that the <see cref="CHandle" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CHandle>(), Is.EqualTo(sizeof(CHandle)));
    }

    /// <summary>Validates that the <see cref="CHandle" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CHandle).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CHandle" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CHandle), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(CHandle), Is.EqualTo(4));
        }
    }
}
