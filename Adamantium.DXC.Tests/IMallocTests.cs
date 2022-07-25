using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IMalloc" /> struct.</summary>
public static unsafe partial class IMallocTests
{
    /// <summary>Validates that the <see cref="IMalloc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMalloc>(), Is.EqualTo(sizeof(IMalloc)));
    }

    /// <summary>Validates that the <see cref="IMalloc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMalloc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMalloc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMalloc), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMalloc), Is.EqualTo(4));
        }
    }
}
