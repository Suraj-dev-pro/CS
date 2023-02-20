//Lambda expression in LINQ
using System;
using System.Collections.Generic;
using System.Linq;

class Program51
{
    static void Main()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        List<int> oddnum = list.FindAll(x => x % 2 != 0);
        foreach(int num in oddnum)
        {
            Console.WriteLine(num + " ");
        }
    }
}