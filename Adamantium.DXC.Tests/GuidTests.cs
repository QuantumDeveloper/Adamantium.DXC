using NUnit.Framework;
using System.Runtime.InteropServices;

namespace System.UnitTests;

/// <summary>Provides validation of the <see cref="Guid" /> struct.</summary>
public static unsafe partial class GuidTests
{
    /// <summary>Validates that the <see cref="Guid" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Guid>(), Is.EqualTo(sizeof(Guid)));
    }

    /// <summary>Validates that the <see cref="Guid" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Guid).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="Guid" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Guid), Is.EqualTo(16));
    }
}
