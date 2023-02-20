//This code demonstrates an example of single inheritance in C#. In single inheritance, a class inherits
//from only one base class. In this case, the Mammal class inherits
//from the Animal class, and the Dog class inherits from the Mammal class.
//This allows the Dog class to access all the members (methods, properties, fields, etc.)
//of the Animal class through inheritance.
using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

class Mammal : Animal
{
    public void Move()
    {
        Console.WriteLine("Moving...");
    }
}

class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

class Program24
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat();
        dog.Move();
        dog.Bark();
    }
}
