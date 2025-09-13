using NUnit.Framework;

[TestFixture]
public class MilesPerGallonTests
{
    [Test]
    public void TestMpgCalculation()
    {
        var mpg = new MilesPerGallon
        {
            Miles = 100,
            Gallons = 5
        };
        Assert.AreEqual(20, mpg.Mpg);
    }

    [Test]
    public void TestNegativeMilesThrowsException()
    {
        var mpg = new MilesPerGallon();
        Assert.Throws<NegativeNumberException>(() => mpg.Miles = -1);
    }

    [Test]
    public void TestNegativeGallonsThrowsException()
    {
        var mpg = new MilesPerGallon();
        Assert.Throws<NegativeNumberException>(() => mpg.Gallons = -1);
    }

    [Test]
    public void TestZeroGallonsThrowsException()
    {
        var mpg = new MilesPerGallon();
        Assert.Throws<CannotBeZeroException>(() => mpg.Gallons = 0);
    }

    [Test]
    public void TestZeroMilesAllowed()
    {
        var mpg = new MilesPerGallon
        {
            Miles = 0,
            Gallons = 1
        };
        Assert.AreEqual(0, mpg.Mpg);
    }
}