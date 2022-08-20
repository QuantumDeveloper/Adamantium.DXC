using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="INoMarshal" /> struct.</summary>
public static unsafe partial class INoMarshalTests
{
    /// <summary>Validates that the <see cref="INoMarshal" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INoMarshal>(), Is.EqualTo(sizeof(INoMarshal)));
    }

    /// <summary>Validates that the <see cref="INoMarshal" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INoMarshal).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="INoMarshal" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(INoMarshal), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(INoMarshal), Is.EqualTo(8));
        }
    }
}
