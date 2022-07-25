using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="LARGE_INTEGER" /> struct.</summary>
public static unsafe partial class LARGE_INTEGERTests
{
    /// <summary>Validates that the <see cref="LARGE_INTEGER" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<LARGE_INTEGER>(), Is.EqualTo(sizeof(LARGE_INTEGER)));
    }

    /// <summary>Validates that the <see cref="LARGE_INTEGER" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(LARGE_INTEGER).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref="LARGE_INTEGER" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(LARGE_INTEGER), Is.EqualTo(8));
    }
}
