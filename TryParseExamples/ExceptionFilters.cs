using System.Net;
using NUnit.Framework;

namespace TryParseExamples;

public class ExceptionFilterTests
{
    [Test]
    public void ExceptionFilterTest()
    {
        string result = null;
        try
        {
            new WebClient().DownloadString("https://google.com/");
        }
        catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout)
        {
            result = "Timeout!";
        }
        catch (WebException ex) when (ex.Status == WebExceptionStatus.NameResolutionFailure)
        {
            result = "Name resolution failure!";
        }
        catch (WebException ex)
        {
            result = $"Some other failure: {ex.Status}";
        }

        Assert.IsNull(result);
    }
}