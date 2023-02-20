// write a c# program to illustate the concept of Abstract Class and method

using System;

abstract class shape
{
    //abstract method
    public abstract double Area();
}
class Rectangular :shape
{
    private double length;
    private double width;

    public Rectangular(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    //implement the abstract method
    public override double Area()
    {
        return length * width;
    }
}
class circle : shape
{
    private double radius;
    public circle(double radius)
    {
        this.radius = radius;
    }
    //implement the abstract method
    public override double Area()
    {
        return Math.PI * radius * radius;
    }

}
class Program21
{
    static void Main(string[]args)
    {
        //create objects of the derived classes
        Rectangular rect = new Rectangular(10, 20);
        circle cir = new circle(5);
        //call abstract method
        Console.WriteLine("Rectangle area:" + rect.Area());
        Console.WriteLine("Circle Area:" + cir.Area());

    }
}