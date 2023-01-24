// C# program to find the sum of even numbers from the list of integers input by user
using System;
using System.Linq;


class Even
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter alist of integer separated by spaces: ");
        String input = Console.ReadLine();

        int[] numbers = input.Split(' ').Select(x => int.Parse(x)).ToArray();

        int evenSum = 0;
        Console.Write("Even number: ");
        for(int i =0; i< numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.Write(numbers[i] + "");
                evenSum += numbers[i];
            }
        }
        Console.WriteLine();
        Console.WriteLine("Sum of even numbers:" + evenSum);
    }
}