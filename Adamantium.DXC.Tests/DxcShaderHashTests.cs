using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DxcShaderHash" /> struct.</summary>
public static unsafe partial class DxcShaderHashTests
{
    /// <summary>Validates that the <see cref="DxcShaderHash" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxcShaderHash>(), Is.EqualTo(sizeof(DxcShaderHash)));
    }

    /// <summary>Validates that the <see cref="DxcShaderHash" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxcShaderHash).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DxcShaderHash" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DxcShaderHash), Is.EqualTo(20));
    }
}
