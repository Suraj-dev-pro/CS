//multi cast delegate
using System;
class Program38
{
    public static int square(int n)
    {
        return n * n;
    }
    public static int cube(int n)
    {
        return n * n * n;
    }
    public delegate int multidelegate(int num);
    static void Main()
    {
        multidelegate del = new multidelegate(square);
        int result = del(5);
        Console.WriteLine("Square of 5= " + result);
        del += cube;
        int result2 = del(10);
        Console.WriteLine("Cube of 10= " + result2);
    }
}