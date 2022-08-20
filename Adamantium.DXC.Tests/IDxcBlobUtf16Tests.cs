using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcBlobUtf16" /> struct.</summary>
public static unsafe partial class IDxcBlobUtf16Tests
{
    /// <summary>Validates that the <see cref="IDxcBlobUtf16" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcBlobUtf16>(), Is.EqualTo(sizeof(IDxcBlobUtf16)));
    }

    /// <summary>Validates that the <see cref="IDxcBlobUtf16" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcBlobUtf16).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcBlobUtf16" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcBlobUtf16), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcBlobUtf16), Is.EqualTo(4));
        }
    }
}
