using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcResult" /> struct.</summary>
public static unsafe partial class IDxcResultTests
{
    /// <summary>Validates that the <see cref="IDxcResult" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcResult>(), Is.EqualTo(sizeof(IDxcResult)));
    }

    /// <summary>Validates that the <see cref="IDxcResult" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcResult).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcResult" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcResult), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcResult), Is.EqualTo(4));
        }
    }
}