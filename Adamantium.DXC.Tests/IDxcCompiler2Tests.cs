using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Adamantium.DXC.IID;

namespace Adamantium.DXC.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcCompiler2" /> struct.</summary>
public static unsafe partial class IDxcCompiler2Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDxcCompiler2" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcCompiler2).GUID, Is.EqualTo(IID_IDxcCompiler2));
    }

    /// <summary>Validates that the <see cref="IDxcCompiler2" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcCompiler2>(), Is.EqualTo(sizeof(IDxcCompiler2)));
    }

    /// <summary>Validates that the <see cref="IDxcCompiler2" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcCompiler2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcCompiler2" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcCompiler2), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcCompiler2), Is.EqualTo(4));
        }
    }
}
