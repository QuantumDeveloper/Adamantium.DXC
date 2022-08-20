using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Adamantium.DXC.IID;

namespace Adamantium.DXC.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcAssembler" /> struct.</summary>
public static unsafe partial class IDxcAssemblerTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDxcAssembler" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcAssembler).GUID, Is.EqualTo(IID_IDxcAssembler));
    }

    /// <summary>Validates that the <see cref="IDxcAssembler" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcAssembler>(), Is.EqualTo(sizeof(IDxcAssembler)));
    }

    /// <summary>Validates that the <see cref="IDxcAssembler" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcAssembler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcAssembler" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcAssembler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcAssembler), Is.EqualTo(4));
        }
    }
}
