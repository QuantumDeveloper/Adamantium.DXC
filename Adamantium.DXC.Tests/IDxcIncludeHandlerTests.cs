using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Adamantium.DXC.IID;

namespace Adamantium.DXC.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcIncludeHandler" /> struct.</summary>
public static unsafe partial class IDxcIncludeHandlerTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDxcIncludeHandler" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcIncludeHandler).GUID, Is.EqualTo(IID_IDxcIncludeHandler));
    }

    /// <summary>Validates that the <see cref="IDxcIncludeHandler" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcIncludeHandler>(), Is.EqualTo(sizeof(IDxcIncludeHandler)));
    }

    /// <summary>Validates that the <see cref="IDxcIncludeHandler" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcIncludeHandler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcIncludeHandler" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcIncludeHandler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcIncludeHandler), Is.EqualTo(4));
        }
    }
}
