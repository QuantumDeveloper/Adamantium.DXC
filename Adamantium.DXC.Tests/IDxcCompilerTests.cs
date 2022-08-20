using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Adamantium.DXC.IID;

namespace Adamantium.DXC.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcCompiler" /> struct.</summary>
public static unsafe partial class IDxcCompilerTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDxcCompiler" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcCompiler).GUID, Is.EqualTo(IID_IDxcCompiler));
    }

    /// <summary>Validates that the <see cref="IDxcCompiler" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcCompiler>(), Is.EqualTo(sizeof(IDxcCompiler)));
    }

    /// <summary>Validates that the <see cref="IDxcCompiler" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcCompiler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcCompiler" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcCompiler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcCompiler), Is.EqualTo(4));
        }
    }
}
