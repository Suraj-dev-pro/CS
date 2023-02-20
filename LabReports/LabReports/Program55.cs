//C# linq aggreagator

using System;
using System.Linq;
using System.Collections.Generic;


    class Program55
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Sum of numbers: " + numbers.Sum());
            Console.WriteLine("Average of numbers: " + numbers.Average());
            Console.WriteLine("Maximum of numbers: " + numbers.Max());
            Console.WriteLine("Minimum of numbers: " + numbers.Min());
            Console.WriteLine("Count of numbers: " + numbers.Count());

            Console.ReadLine();
        }
    }

