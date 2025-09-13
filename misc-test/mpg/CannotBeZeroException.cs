using System;

public class CannotBeZeroException : ArgumentOutOfRangeException
{
    public CannotBeZeroException(string parameter): base(parameter, "value cannot be 0")
    {
        // empty
    }
}