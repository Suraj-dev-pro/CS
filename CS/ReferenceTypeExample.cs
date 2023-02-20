//referencetype
using System;
class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class ReferenceTypeExample
{
    static void Main()
    {
        Point p1 = new Point { X = 3, Y = 4 };
        Point p2 = p1;

        Console.WriteLine("p1: {0}, {1}", p1.X, p1.Y); // Output: p1: 3, 4
        Console.WriteLine("p2: {0}, {1}", p2.X, p2.Y); // Output: p2: 3, 4

        p1.X = 7;
        Console.WriteLine("p1: {0}, {1}", p1.X, p1.Y); // Output: p1: 7, 4
        Console.WriteLine("p2: {0}, {1}", p2.X, p2.Y); // Output: p1: 7, 4
    }
}
