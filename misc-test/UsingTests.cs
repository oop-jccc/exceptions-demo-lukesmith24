using System.IO;
using NUnit.Framework;

namespace Tests;

public class UsingTests
{
    [Test]
    public void FileOpenFinallyTest()
    {
        Assert.Throws<FileNotFoundException>(() =>
        {
            FileStream stream = null;
            try
            {
                stream = new FileStream("file.txt", FileMode.Open);
                // code to read or write to the stream
            }
            finally
            {
                stream?.Dispose();
            }
        });
    }

    [Test]
    public void FileOpenUsingStatementTest()
    {
        Assert.Throws<FileNotFoundException>(() =>
        {
            using (var stream = new FileStream("file.txt", FileMode.Open))
            {
                // code to read or write to the stream
            }
        });
    }

    [Test]
    public void FileOpenUsingDeclarationTest()
    {
        Assert.Throws<FileNotFoundException>(() =>
        {
            using var stream = new FileStream("file.txt", FileMode.Open);
            // code to read or write to the stream
        });
    }
}