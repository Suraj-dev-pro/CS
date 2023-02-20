//Write a Program in C# to compute simple interest and compound interes and calculate the amount payable
using System;

public class Program4
{
    public static void Main()
    {
        float p, t, r;
        float amount, si, ci;

        Console.WriteLine("Enter Principal amount, time, rate of interest to calculate compound interest");
        Console.Write("Principal amount: ");
        p = float.Parse(Console.ReadLine());
        Console.Write("Time: ");
        t = float.Parse(Console.ReadLine());
        Console.Write("Rate: ");
        r = float.Parse(Console.ReadLine());

        amount = p * (float)Math.Pow(1 + r / 100, t);
        si = (p * t * r) / 100;
        ci = amount - p;
        Console.WriteLine("Simple Interest: {0}", si);
        Console.WriteLine("Compound Interest: {0}", ci);
        Console.WriteLine("Total amount Payable: {0}", amount);
        Console.ReadKey();
    }
}
