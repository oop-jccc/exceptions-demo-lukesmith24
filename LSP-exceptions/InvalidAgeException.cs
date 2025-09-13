using System;

namespace Tests;

public class InvalidAgeException : Exception
{
    public InvalidAgeException()
    {
    }

    public InvalidAgeException(string message) : base(message)
    {
    }

    public InvalidAgeException(string message, Exception innerException) : base(message, innerException)
    {
    }
}