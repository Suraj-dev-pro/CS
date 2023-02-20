//Write a C# program to find smallest number among the entered three number using nested if statement

using System;

class Program6
{
    static void Main()
    {
        int a, b, c, small;
        Console.WriteLine("Enter the value of a");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of b: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of c: ");
        c = int.Parse(Console.ReadLine());

        if(a<b)
        {
            if (b < c)
                small = a;
            else
            {
                if (a < c)
                    small = a;
                else small = c;
            }
        }
        else
        {
            if (b < c)
                small = b;
            else
                small = c;

        }

        Console.WriteLine("Smallest Number is: " + small);
        Console.ReadKey();
    }
}