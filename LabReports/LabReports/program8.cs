// Write a C# program to find the sum of firest user provided natural number (nth term)

using System;
class Program8
{
    static void Main()
    {
        int i, n, sum = 0;
        Console.Write("\n\n");

        Console.Write("Display n terms of natural number and their sum.\n");
        Console.Write("-------------------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input the value of terms: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("\n The first {0} natural number are: \n", n);
        for(i=1; i<=n;i++)
        {
            Console.Write("{0} ", i);
            sum += i;
        }
        Console.Write("\n The sum of natural number upto {0} terms: {1}", n, sum);
    }
}