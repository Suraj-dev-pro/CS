//C# program to implement concept of method overriding using virtual method
using System;
abstract class Animals
{
    public virtual string MakeSound()
    {
       return "I' am making a generic animal sound";
    }
}
class Cat:Animals
{
    public override string MakeSound()
    {
        return "Meow";
    }
}
class Cow : Animals
{
    public override string MakeSound()
    {
        return "Moow";
    }
}
class Program27
{
    static void Main()
    {
        Animals cat = new Cat();
        Console.WriteLine(cat.MakeSound());
        Animals cow = new Cow();
        Console.WriteLine(cow.MakeSound());
    }
}