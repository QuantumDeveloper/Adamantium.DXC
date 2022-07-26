using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DxcDefine" /> struct.</summary>
public static unsafe partial class DxcDefineTests
{
    /// <summary>Validates that the <see cref="DxcDefine" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxcDefine>(), Is.EqualTo(sizeof(DxcDefine)));
    }

    /// <summary>Validates that the <see cref="DxcDefine" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxcDefine).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DxcDefine" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DxcDefine), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(DxcDefine), Is.EqualTo(8));
        }
    }
}
