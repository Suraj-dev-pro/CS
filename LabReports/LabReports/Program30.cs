//C# program to overload relational operator
using System;

class Distances
{
    int feet, inches;
    public Distances(int f, int i)
    {
        feet = f;
        inches = i;
    }
    public static bool operator <(Distances d1,Distances d2)
    {
        bool status = false;
        int t1 = d1.feet * 12 + d1.inches;
        int t2 = d2.feet * 12 + d2.inches;
        if (t1 < t2)

            status = false;
        else
            status = true;
        return status;
    }
    public static bool operator >(Distances d1, Distances d2)
    {
        bool status = false;
        int t1 = d1.feet * 12 + d1.inches;
        int t2 = d1.feet * 12 + d1.inches;
        if (t1 > t2)
            status = true;
        else
            status = false;
        return status;
    }
    

}
class Program30
{
    static void Main()
    {
        Distances d1 = new Distances(4, 7);
        Distances d2 = new Distances(9, 8);

        if (d1 < d2)
            Console.WriteLine("Distance d2 is greater");
        else
            Console.WriteLine("Distance d1 is greater");
        Console.ReadKey();
    }

}