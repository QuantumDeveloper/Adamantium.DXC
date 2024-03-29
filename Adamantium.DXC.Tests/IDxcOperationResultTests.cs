using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Adamantium.DXC.Unix.UnitTests;

/// <summary>Provides validation of the <see cref="IDxcOperationResult" /> struct.</summary>
public static unsafe partial class IDxcOperationResultTests
{
    /// <summary>Validates that the <see cref="IDxcOperationResult" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcOperationResult>(), Is.EqualTo(sizeof(IDxcOperationResult)));
    }

    /// <summary>Validates that the <see cref="IDxcOperationResult" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcOperationResult).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDxcOperationResult" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcOperationResult), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcOperationResult), Is.EqualTo(4));
        }
    }
}
