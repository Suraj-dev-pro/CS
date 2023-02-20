//anonymous and lambda expression c#
using System;

public delegate int operation(int a, int b);

class Program39
{
    
    static void Main()
    {
        //anonymous method

        operation add = delegate (int a, int b)
        {
            return a + b;
        };
        int sum = add(76, 78);
        Console.WriteLine(" the sum: {0}", sum);
        //lambda expression
        operation multiply = (int x, int y) => x * y;
        int result= multiply(20,30);
        Console.WriteLine("the multiply {0}", result);
    }
 }