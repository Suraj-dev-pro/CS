// Write a c# code to find entered number , user enters is negative or positive

using System;

public class Program11
{
    public static void Main(string[]args)
    {
        int num;
        Console.WriteLine("Check whether a number is positive or negative");

        Console.WriteLine("Input an integer to check: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num >= 0)
            Console.WriteLine("{0} Number is Positive",num);
        else
            Console.WriteLine("{0} Number is Negative",num);
        
    }

}