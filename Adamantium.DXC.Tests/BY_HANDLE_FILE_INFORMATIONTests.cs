using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="BY_HANDLE_FILE_INFORMATION" /> struct.</summary>
public static unsafe partial class BY_HANDLE_FILE_INFORMATIONTests
{
    /// <summary>Validates that the <see cref="BY_HANDLE_FILE_INFORMATION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BY_HANDLE_FILE_INFORMATION>(), Is.EqualTo(sizeof(BY_HANDLE_FILE_INFORMATION)));
    }

    /// <summary>Validates that the <see cref="BY_HANDLE_FILE_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BY_HANDLE_FILE_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="BY_HANDLE_FILE_INFORMATION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(BY_HANDLE_FILE_INFORMATION), Is.EqualTo(52));
    }
}
