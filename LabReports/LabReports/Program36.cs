//C# LinkedList
using System;
using System.Collections.Generic;

public class Program36
{
    public static void Main()
    {
        LinkedList<int> ld = new LinkedList<int>();
        ld.AddFirst(90);
        ld.AddAfter(ld.Find(90),70);
        ld.AddBefore(ld.Find(70), 60);
        ld.AddLast(80);

        Console.WriteLine("total number of elements in linked list is {0}", ld.Count);

        Console.WriteLine("Values in Linked List: ");
        foreach(int i in ld)
        {
            Console.WriteLine(i + " ");
        }

        ld.Remove(80);
        ld.RemoveFirst();
        ld.RemoveLast();
        Console.WriteLine("Print the value of Linked List:");
        foreach(int i in ld)
        
            Console.WriteLine(i + "");
        
    }
}