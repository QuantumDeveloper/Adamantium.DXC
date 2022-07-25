using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IUnknown" /> struct.</summary>
public static unsafe partial class IUnknownTests
{
    /// <summary>Validates that the <see cref="IUnknown" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IUnknown>(), Is.EqualTo(sizeof(IUnknown)));
    }

    /// <summary>Validates that the <see cref="IUnknown" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IUnknown).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IUnknown" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IUnknown), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(IUnknown), Is.EqualTo(8));
        }
    }
}
