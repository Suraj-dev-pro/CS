//Example of reference in C#
using System;
class ReferenceExample
{
    static void Main(string[] args)
    {
        int x = 5;
        int y = 10;

        // Pass by value
        int result = Add(x, y);
        Console.WriteLine("Addition of x and y (pass by value): " + result);

        // Pass by reference
        int sum = 0;
        Add(ref x, ref y, ref sum);
        Console.WriteLine("Addition of x and y (pass by reference): " + sum);
    }

    // Pass by value method
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Pass by reference method
    static void Add(ref int a, ref int b, ref int c)
    {
        c = a + b;
    }
}
