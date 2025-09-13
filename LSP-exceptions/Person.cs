namespace Tests;

public class Person
{
    private int _age;

    protected int MaxAge { get; set; } = 120;
    protected int MinAge { get; set; }

    public virtual int Age
    {
        get => _age;

        set
        {
            CheckAge(value);
            _age = value;
        }
    }

    private void CheckAge(int value)
    {
        if (value < MinAge || value > MaxAge)
        {
            throw new InvalidAgeException($"Age must be between {MinAge} and {MaxAge}");
        }
    }
}

public class Child : Person
{
    public Child()
    {
        MinAge = 0;
        MaxAge = 12;
    }
}