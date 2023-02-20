// write a C# program to convert Celsius into fahrenheit
using System;

public class Program
{
    public static void Main()
    {
        double c, f;
        Console.WriteLine(" Input C");
        c = double.Parse(Console.ReadLine());
        f = (c * 9 / 5) + 32;
        Console.WriteLine("{0}c={1}f", c, f);
        Console.ReadKey();
    }

}