using System;

namespace Exceptions_Demo;

internal static class Program
{
    private static void Main(string[] args)
    {
        Unhandled();
        //Handled();
        //TryParse();
        //ThrowExample();
    }

    private static void Unhandled()
    {
        Console.WriteLine("Enter and integer");
        var input = Console.ReadLine();
        var output = int.Parse(input);
        Console.WriteLine(output);
    }

    private static void Handled()
    {
        try
        {
            Unhandled();
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("Thank you");
        }
    }

    private static void TryParse()
    {
        Console.WriteLine("Enter and integer");
        var input = Console.ReadLine();
        var success = int.TryParse(input, out var output);

        if (success)
        {
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("You did something wrong.");
        }
    }

    private static void ThrowExample()
    {
        Console.WriteLine("Enter and integer");
        var input = Console.ReadLine();
        if (input == null) return;
        var output = int.Parse(input);
        if (output < 0) throw new NegativeNumberException();
    }
}