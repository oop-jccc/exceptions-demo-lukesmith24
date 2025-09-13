using System.Collections.Generic;
using NUnit.Framework;

namespace Tests;

public class PersonAgeTests
{

    [Test]
    public void InvalidAgeExceptionTest()
    {
        var ex = Assert.Throws<InvalidAgeException>(() =>
        {
            _ = new List<Person> // a Person can have an age between 0 and 120
            {
                new Person {Age = 99},
                new Child {Age = 99} // throws because Child age is more restrictive than Person
            };
        });

        Assert.AreEqual(ex.Message, "Age must be between 0 and 12");
    }
}