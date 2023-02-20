// write a C# program if entered number is multiple of 5 then add 2 to it and display the resultant number

using System;

class Program5
{
    static void Main()
    {
        int n;
        Console.WriteLine("Enter multiple of 5");
        n = int.Parse(Console.ReadLine());
        if(n%5==0)
        {
            n += 2;
            Console.WriteLine(" The resultant number is: " + n);
        }
        else
        {
            Console.WriteLine("Not a multiple of 5");
        }
        Console.ReadKey();
    }
}