//single cast delegate
using System;
class Program37
{
    public static int square(int n)
    {
        return n * n;
    }
    public delegate int squaredelegate(int num);
    static void Main()
    {
        squaredelegate del = new squaredelegate(square);
        int result = del(5);
        Console.WriteLine("Square of 5 =" + result);
    }
}