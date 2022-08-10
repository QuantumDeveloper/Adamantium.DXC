using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcBlob" /> struct.</summary>
public static unsafe partial class IDxcBlobTests
{
    /// <summary>Validates that the <see cref="IDxcBlob" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcBlob>(), Is.EqualTo(sizeof(IDxcBlob)));
    }

    /// <summary>Validates that the <see cref="IDxcBlob" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcBlob).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcBlob" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcBlob), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcBlob), Is.EqualTo(4));
        }
    }
}
