using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="FILETIME" /> struct.</summary>
public static unsafe partial class FILETIMETests
{
    /// <summary>Validates that the <see cref="FILETIME" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FILETIME>(), Is.EqualTo(sizeof(FILETIME)));
    }

    /// <summary>Validates that the <see cref="FILETIME" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FILETIME).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="FILETIME" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FILETIME), Is.EqualTo(8));
    }
}
