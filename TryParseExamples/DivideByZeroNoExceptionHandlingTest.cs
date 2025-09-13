using System;
using NUnit.Framework;


namespace TryParseExamples;

public class DivideByZeroNoExceptionHandlingTests
{
    [Test]
    public void DivideByZeroNoExceptionHandlingTest()
    {
        var success = true;
        var numerator = 5;
        var denominator = 0;

        try
        {
            _ = numerator / denominator;
        }
        catch (DivideByZeroException e)
        {
            success = false;
            return; // still hits the finally
        }
        finally
        {
            Assert.IsFalse(success);
        }
    }

    [Test]
    public void DivideByZeroUnhandledExceptionHandlingTest()
    {
        var numerator = 5;
        var denominator = 0;
        Assert.Throws<DivideByZeroException>(() =>
        {
            _ = numerator / denominator;
        });
            
    }
}