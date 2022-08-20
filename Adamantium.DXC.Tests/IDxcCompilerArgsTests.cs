using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Adamantium.DXC.IID;

namespace Adamantium.DXC.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcCompilerArgs" /> struct.</summary>
public static unsafe partial class IDxcCompilerArgsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDxcCompilerArgs" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcCompilerArgs).GUID, Is.EqualTo(IID_IDxcCompilerArgs));
    }

    /// <summary>Validates that the <see cref="IDxcCompilerArgs" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcCompilerArgs>(), Is.EqualTo(sizeof(IDxcCompilerArgs)));
    }

    /// <summary>Validates that the <see cref="IDxcCompilerArgs" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcCompilerArgs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcCompilerArgs" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcCompilerArgs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcCompilerArgs), Is.EqualTo(4));
        }
    }
}
