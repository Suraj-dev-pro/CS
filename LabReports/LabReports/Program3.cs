// Write a C# program to compute area and perimeter of circle

using System;
public class Program3
{
    public static void Main()
    {
        int radius;
        double area, perimeter;

        Console.WriteLine("Enter the value of radius:");
        radius = int.Parse(Console.ReadLine());
        area = Math.PI * radius * radius;
        perimeter = 2* Math.PI *radius;

        Console.WriteLine("Area of the circle is " + Math.Round(area));
        Console.WriteLine("Perimeter of the circle is " + Math.Round(perimeter));
        Console.ReadKey();
    }
}