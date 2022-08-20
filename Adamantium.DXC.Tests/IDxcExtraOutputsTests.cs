using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Adamantium.DXC.IID;

namespace Adamantium.DXC.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcExtraOutputs" /> struct.</summary>
public static unsafe partial class IDxcExtraOutputsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDxcExtraOutputs" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcExtraOutputs).GUID, Is.EqualTo(IID_IDxcExtraOutputs));
    }

    /// <summary>Validates that the <see cref="IDxcExtraOutputs" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcExtraOutputs>(), Is.EqualTo(sizeof(IDxcExtraOutputs)));
    }

    /// <summary>Validates that the <see cref="IDxcExtraOutputs" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcExtraOutputs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcExtraOutputs" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcExtraOutputs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcExtraOutputs), Is.EqualTo(4));
        }
    }
}
