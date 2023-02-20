// Write a c# program to check whether the entered number is armstrong or not

using System;
public class Program9
{
    public static void Main(string[]args)
    {
        int n, r, sum = 0, temp;
        Console.WriteLine("Enter the Number =");
        n = int.Parse(Console.ReadLine());
        temp = n;
        while(n>0)
        {
            r = n % 10;
            sum = sum + (r * r * r);
            n = n / 10;
        }
        if (temp == sum)
            Console.WriteLine("Armstrong Number.");
        else
            Console.WriteLine("Not an Armstrong Number:");

        Console.ReadKey();
    }
    
}