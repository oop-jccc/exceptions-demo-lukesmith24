namespace CH13_Exceptions_Demo;

public class MilesPerGallon
{
    private double _gallons;
    private double _miles;

    public double Mpg => Miles / Gallons;

    public double Miles
    {
        get => _miles;
        set
        {
            ValidateNonNegative(value);
            _miles = value;
        }
    }

    public double Gallons
    {
        get => _gallons;
        set
        {
            ValidateNonNegative(value);
            ValidateNonZero(value);
            _gallons = value;
        }
    }
    
    private static void ValidateNonNegative(double value)
    {
        if (value < 0)
        {
            throw new NegativeNumberException("Miles cannot be negative");
        }
    }

    private static void ValidateNonZero(double value)
    {
        if (value == 0)
        {
            throw new CannotBeZeroException("Gallons cannot be zero");
        }
    }
}