//Write a C# program to compute area and perimter of rectangle

using System;

public class Program2
{
    public static void Main()
    {
        
        Console.WriteLine("Enter the height of the rectangle");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width of the rectangle");
        double width = double.Parse(Console.ReadLine());

        double area = height * width;
        double perimeter = 2 * (height + width);

        Console.WriteLine("Area:{0}", area);
        Console.WriteLine("Perimeter:{0}", perimeter);

        Console.ReadKey();

    }
}