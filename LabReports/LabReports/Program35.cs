//C# queue
using System;
using System.Collections.Generic;

public class Program35
{
    static void Main()
    {
        Queue<string> str = new Queue<string>();

        str.Enqueue("H");
        str.Enqueue("E");
        str.Enqueue("L");
        str.Enqueue("L");
        str.Enqueue("O");
        Console.WriteLine("Total elements ={0}", str.Count);

        while (str.Count > 0)
            Console.WriteLine(str.Dequeue());

        Console.WriteLine("Total elements={0}", str.Count);
    }
}