/*An interface in computer programming is a set of instructions or rules that define how a class or struct should
 * behave. It defines a contract that a class or struct must adhere to, specifying a list of methods, properties,
 * and events that the class or struct must implement. Interfaces are a way to achieve polymorphism in 
 * object-oriented programming, as a single interface can be implemented by multiple classes or structs,
 * allowing them to be used interchangeably. In C#, interfaces are defined using the "interface" keyword, 
 * and classes or structs implement an interface using the ": interfaceName" syntax. Interfaces 
 *cannot be instantiated, they only provide a blueprint of what methods, properties, 
 *and events a class or struct should have.*/
using System;

public interface IShape
{
    double GetArea();
    double GetPerimeter();
}
public class Rectangle:IShape
{
    public double width { get; set; }
    public double height { get; set; }

    public double GetArea()
    {
        return width * height;
    }
    public double GetPerimeter()
    {
        return 2 * (width + height);
    }
}
public class Circle : IShape
{
    public double radius { get; set; }
    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
}
class InterfaceExample
{
    static void Main(string[] args)
    {
        IShape rect = new Rectangle { width = 10, height = 20 };
        Console.WriteLine("Rectangle Area: " + rect.GetArea());
        Console.WriteLine("Perimeter of Rectangle: " + rect.GetPerimeter());

        IShape circle = new Circle { radius = 25 };
        Console.WriteLine("Area of Circle: " + circle.GetArea());
        Console.WriteLine("Perimeter of Circle:" + circle.GetPerimeter());

    }

}