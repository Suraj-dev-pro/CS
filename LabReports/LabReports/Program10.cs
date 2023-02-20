// Write a C# program to find sum of odd number of first n natural number

using System;
 class Program10
{
    static void Main()
    {
        int i, n, sum = 0;
        Console.Write("\n\n");
        Console.Write("Display the sum of n odd natural number:\n");
        Console.Write("------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input number of terms:");
        n = Convert.ToInt32(Console.ReadLine());
        for(i =1; i<=n;i++)
        {
            Console.WriteLine("{0}", 2 * i - 1);
            sum += 2 *i - 1;
        }
        Console.Write("\n The sum of odd Natural Number upto {0} terms:{1}", n, sum);
    }
}