using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Adamantium.DXC.IID;

namespace Adamantium.DXC.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcPdbUtils" /> struct.</summary>
public static unsafe partial class IDxcPdbUtilsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDxcPdbUtils" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcPdbUtils).GUID, Is.EqualTo(IID_IDxcPdbUtils));
    }

    /// <summary>Validates that the <see cref="IDxcPdbUtils" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcPdbUtils>(), Is.EqualTo(sizeof(IDxcPdbUtils)));
    }

    /// <summary>Validates that the <see cref="IDxcPdbUtils" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcPdbUtils).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcPdbUtils" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcPdbUtils), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcPdbUtils), Is.EqualTo(4));
        }
    }
}
