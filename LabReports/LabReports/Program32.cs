//C# program List<>
using System;
using System.Collections.Generic;

class Program32
{
    static void Main()
    {
        List<int> intlist = new List<int>();
        intlist.Add(70);
        intlist.Add(80);
        intlist.Add(65);
        intlist.Add(95);
        intlist.Add(30);
        Console.WriteLine("Number in the list are:");
        foreach (int i in intlist)
        {
            Console.WriteLine(i + " ");
        }
        intlist.Insert(0, 20);
        Console.WriteLine("After inserting a new number at the beginning of list");
        foreach(int i in intlist)
        {
            Console.WriteLine(i + " ");
        }
        intlist.RemoveAt(2);
        Console.WriteLine("Number in the liste after remove at index 2:");
        foreach(int i in intlist)
        {
            Console.WriteLine(i + " ");
        }
        Console.ReadKey();
    }

}