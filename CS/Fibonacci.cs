// C# program to fibonacci series upto 20 terms
using System;

class Fibonacci
{
    static void Main(string[]args)
    {
        int n1 = 0, n2 = 1, n3, i;
        Console.Write(n1 + " " + n2 + " ");
        for(i = 2; i< 20;++i)
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }
    }
}
