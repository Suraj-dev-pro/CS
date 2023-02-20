//Write a circle containing private variable radius of type float, suitable constructor
//and two methods finArea and findCircumference of circles respectively.
//Write a separate class Circle contatining main Method to create and use cirlc object.
using System;
class Circle
{
    //private field to store the radius of the circle
    private float radius;
    //constructor to initialize the radius of the circle
    public Circle(float radius)
    {
        this.radius = radius;
    }
    //method to find the area of circle
    public float findArea()
    {
        return (float)(Math.PI * Math.Pow(radius, 2));
    }
    //method to find the circumference of the circle
    public float findCircumference()
    {
        return (float)(2 * Math.PI * radius);
    }
}
class Program17
{
     static void Main()
    {
        Circle c = new Circle(5);
        Console.WriteLine("Area of circle: " + c.findArea());
        Console.WriteLine("Circumference of circle :" + c.findCircumference());

    }
}