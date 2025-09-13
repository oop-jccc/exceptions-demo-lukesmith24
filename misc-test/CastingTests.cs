using System;
using NUnit.Framework;

namespace Tests;

class Animal
{
}

class Dog : Animal
{
    public string Bark { get; init; } = "Woof";
}

class Cat : Animal
{
    public string Meow { get; init; } = "Meow";
}

public class CastingTests
{
    [Test]
    public void InvalidCastTest()
    {
        Assert.Throws<InvalidCastException>(() =>
        {
            Animal animal = new Dog();
            var cat = (Cat)animal;
        });
    }

    [Test]
    public void IsOperatorTest()
    {
        Animal animal = new Dog();
        Assert.IsFalse(animal is Cat);
    }

    [Test]
    public void AsOperatorTest()
    {
        Animal animal = new Dog();
        Assert.IsNull(animal as Cat);
    }

    [Test]
    public void AsOperatorTest2()
    {
        Animal animal = new Cat();
        var cat = animal as Cat;

        Assert.That(cat.Meow, Is.EqualTo("Meow")); // this would cause a NullReferenceException if animal were not a cat.
    }

    [Test]
    public void IsOperatorPatternMatching()
    {
        Animal animal = new Cat();

        if (animal is Cat cat)
        {
            Assert.That(cat.Meow, Is.EqualTo("Meow"));
            //The if (animal is Cat cat) statement combines the test with an initialization assignment.
            //The assignment occurs only when the test succeeds.
        }
        else
        {
            Assert.Fail("animal is not a cat");
        }
    }
}