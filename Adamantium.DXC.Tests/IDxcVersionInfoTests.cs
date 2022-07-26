using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Adamantium.DXC.IID;

namespace Adamantium.DXC.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcVersionInfo" /> struct.</summary>
public static unsafe partial class IDxcVersionInfoTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDxcVersionInfo" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcVersionInfo).GUID, Is.EqualTo(IID_IDxcVersionInfo));
    }

    /// <summary>Validates that the <see cref="IDxcVersionInfo" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcVersionInfo>(), Is.EqualTo(sizeof(IDxcVersionInfo)));
    }

    /// <summary>Validates that the <see cref="IDxcVersionInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcVersionInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcVersionInfo" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcVersionInfo), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcVersionInfo), Is.EqualTo(4));
        }
    }
}
