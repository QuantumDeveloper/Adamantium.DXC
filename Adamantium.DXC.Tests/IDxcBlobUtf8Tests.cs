using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcBlobUtf8" /> struct.</summary>
public static unsafe partial class IDxcBlobUtf8Tests
{
    /// <summary>Validates that the <see cref="IDxcBlobUtf8" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcBlobUtf8>(), Is.EqualTo(sizeof(IDxcBlobUtf8)));
    }

    /// <summary>Validates that the <see cref="IDxcBlobUtf8" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcBlobUtf8).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcBlobUtf8" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcBlobUtf8), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcBlobUtf8), Is.EqualTo(4));
        }
    }
}
