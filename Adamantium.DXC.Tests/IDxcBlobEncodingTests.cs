using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcBlobEncoding" /> struct.</summary>
public static unsafe partial class IDxcBlobEncodingTests
{
    /// <summary>Validates that the <see cref="IDxcBlobEncoding" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcBlobEncoding>(), Is.EqualTo(sizeof(IDxcBlobEncoding)));
    }

    /// <summary>Validates that the <see cref="IDxcBlobEncoding" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcBlobEncoding).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcBlobEncoding" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcBlobEncoding), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcBlobEncoding), Is.EqualTo(4));
        }
    }
}