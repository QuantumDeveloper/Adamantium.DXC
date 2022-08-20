using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IStream" /> struct.</summary>
public static unsafe partial class IStreamTests
{
    /// <summary>Validates that the <see cref="IStream" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IStream>(), Is.EqualTo(sizeof(IStream)));
    }

    /// <summary>Validates that the <see cref="IStream" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IStream).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IStream" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IStream), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IStream), Is.EqualTo(4));
        }
    }
}
