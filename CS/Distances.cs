/*Write a C# program to create a class Distance which represents time.The class should have two fields 
 * for feet and inch.It should have constructor to initialize the feet and inch and method displayDistance() 
 * to print the Distance.Overload the following operators: 
 * -(subtract two distance objects),<(compare two Distance Objects)*/
using System;
class Distance
{
    public int Feet { get; set; }
    public int Inches { get; set; }

    public Distance(int feet, int inches)
    {
        Feet = feet;
        Inches = inches;
    }

    public void DisplayDistance()
    {
        Console.WriteLine("Distance: " + Feet + " feet " + Inches + " inches");
    }

    public static Distance operator -(Distance d1, Distance d2)
    {
        int feet = d1.Feet - d2.Feet;
        int inches = d1.Inches - d2.Inches;
        if (inches < 0)
        {
            inches += 12;
            feet--;
        }
        return new Distance(feet, inches);
    }

    public static bool operator <(Distance d1, Distance d2)
    {
        if (d1.Feet < d2.Feet)
            return true;
        if (d1.Feet == d2.Feet && d1.Inches < d2.Inches)
            return true;
        return false;
    }

    public static bool operator >(Distance d1, Distance d2)
    {
        return !(d1 < d2);
    }
}

class Distances
{
    static void Main(string[] args)
    {
        Distance d1 = new Distance(3, 6);
        Distance d2 = new Distance(2, 8);
        Distance d3 = new Distance(3, 6);

        Console.Write("Distance 1: ");
        d1.DisplayDistance();
        Console.Write("Distance 2: ");
        d2.DisplayDistance();

        Console.Write("Distance 1 - Distance 2: ");
        (d1 - d2).DisplayDistance();

        Console.WriteLine("Distance 1 < Distance 2: " + (d1 < d2));
        Console.WriteLine("Distance 1 > Distance 2: " + (d1 > d2));
        Console.WriteLine("Distance 1 == Distance 3: " + (d1 == d3));
    }
}
