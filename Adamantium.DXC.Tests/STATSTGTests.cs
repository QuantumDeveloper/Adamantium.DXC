using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="STATSTG" /> struct.</summary>
public static unsafe partial class STATSTGTests
{
    /// <summary>Validates that the <see cref="STATSTG" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STATSTG>(), Is.EqualTo(sizeof(STATSTG)));
    }

    /// <summary>Validates that the <see cref="STATSTG" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STATSTG).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="STATSTG" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(STATSTG), Is.EqualTo(80));
        }
        else
        {
            Assert.That(sizeof(STATSTG), Is.EqualTo(72));
        }
    }
}
