//c# stack<T>
using System;
using System.Collections.Generic;

public class Program34
{
    public static void Main()
    {
        Stack<int> mystack = new Stack<int>();
        mystack.Push(1);
        mystack.Push(3);
        mystack.Push(8);
        mystack.Push(6);
        mystack.Push(7);
        Console.WriteLine("Number of stack elements is {0}", mystack.Count);

        while (mystack.Count > 0)
            Console.WriteLine(mystack.Pop() + ", ");

        Console.WriteLine("Number of elements in stack:{0}", mystack.Count);
    }
}