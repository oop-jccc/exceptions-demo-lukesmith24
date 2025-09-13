#nullable enable
using System;
using System.Text;
using NUnit.Framework;

namespace TryParseExamples;

public class NullableTests
{
    [Test]
    public void NullCoalescingTest()
    {
        string? s1 = null;

        // old way
        var s2 = s1 == null ? "nothing" : s1;
        Assert.AreEqual("nothing", s2);

        // new way - null-coalescing operator
        var s3 = s1 ?? "nothing";
        Assert.AreEqual("nothing", s3);
    }

    [Test]
    public void PropertyAccessErrorTest()
    {
        StringBuilder? sb = null;
        Assert.Throws<NullReferenceException>(() => { _ = sb.Length; });
    }

    [Test]
    public void NullConditionalTest() //?. null-conditional operator
    {
        StringBuilder? sb = null;
        var s = sb?.ToString()?.ToUpper();
        int? length = s?.Length;

        Assert.AreEqual(0, length.GetValueOrDefault());
    }

    [Test]
    public void NullCoalescingNullConditionalTest() // ?? and ?.
    {
        StringBuilder? sb = null;
        var s = sb?.ToString().ToUpper() ?? "nothing";
        Assert.AreEqual("nothing", s);
    }
}