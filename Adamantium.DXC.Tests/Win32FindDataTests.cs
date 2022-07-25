using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="Win32FindData" /> struct.</summary>
public static unsafe partial class Win32FindDataTests
{
    /// <summary>Validates that the <see cref="Win32FindData" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Win32FindData>(), Is.EqualTo(sizeof(Win32FindData)));
    }

    /// <summary>Validates that the <see cref="Win32FindData" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Win32FindData).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="Win32FindData" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Win32FindData), Is.EqualTo(1140));
    }
}
