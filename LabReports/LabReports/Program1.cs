// write a C# program to add two integer from command line      
using System;
public class Program1
{
    public static void Main()
    {
        int n1,n2,sum;
        Console.WriteLine("Find the sum of two numbers:");
        Console.WriteLine("Input the number n1");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the number n2");
        n2 = Convert.ToInt32(Console.ReadLine());
        sum = n1 + n2;
        Console.WriteLine("The sum of two numbers n1 & n2: "+sum);

        Console.ReadKey();

    }
}
