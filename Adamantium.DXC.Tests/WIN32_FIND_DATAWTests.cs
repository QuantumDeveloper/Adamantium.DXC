using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="WIN32_FIND_DATAW" /> struct.</summary>
public static unsafe partial class WIN32_FIND_DATAWTests
{
    /// <summary>Validates that the <see cref="WIN32_FIND_DATAW" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WIN32_FIND_DATAW>(), Is.EqualTo(sizeof(WIN32_FIND_DATAW)));
    }

    /// <summary>Validates that the <see cref="WIN32_FIND_DATAW" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WIN32_FIND_DATAW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WIN32_FIND_DATAW" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WIN32_FIND_DATAW), Is.EqualTo(1140));
    }
}
