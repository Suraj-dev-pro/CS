//Write a C# program to implement the concept of method overloading
/* Method overloading by changing the number of parameters*/

using System;
class Program26
{
    static int Calculate(int x, int y)
    {
        return x + y;
    }
    static int Calculate(int x, int y, int z)
    {
        return x + y + z;
    }
    static int Calculate(int x, int y, int z, int w)
    {
        return x + y + z + w;
    }
    static void Main(string[]args)
    {
        Console.WriteLine(Calculate(10, 5));
        Console.WriteLine(Calculate(10, 5, 2));
        Console.WriteLine(Calculate(10, 5, 2, 3));
    }
    
}