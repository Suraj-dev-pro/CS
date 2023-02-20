//Write a c# program to illustrate hierarchial inheritance
using System;
class shapes
{
    public void PrintShape()
    {
        Console.WriteLine("I am a shape");
    }
}
class Circles: shapes
{
    public void Printcirlce()
    {
        Console.WriteLine(" I am a circle");
    }
}
class Square:shapes
{
    public void Printsquare()
    {
        Console.WriteLine("I am a square");
    }
}
class Program23
{
    static void Main()
    {
        Circles circle = new Circles();
        circle.PrintShape();
        circle.Printcirlce();
        Square square = new Square();
        square.PrintShape();
        square.Printsquare();
        

    }
}