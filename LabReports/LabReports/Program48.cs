//write a C# program too select odd and divisible by 3 number from list of number using LINQ query

using System;
using System.Collections.Generic;
using System.Linq;

class Program48
{
    static void Main(string[]args)
    {
        //create a list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //use the method syntax to select add numbers that are divisible by 3
        var addDivisibleByThree = numbers.Where(n => n % 2 == 1 && n % 3 == 0);
        //print out the select numbers
        foreach(int n in addDivisibleByThree)
        {
            Console.WriteLine(n);
        }
    }
}