//By changing the type of parameter
using System;

class MethodOverloading2
{
    public void Display(int num)
    {
        Console.WriteLine("The number is: " + num);
    }

    public void Display(double num1, int num2)
    {
        Console.WriteLine("The numbers are: " + num1 + " and " + num2);
    }

    public void Display(int num1, int num2, int num3)
    {
        Console.WriteLine("The numbers are: " + num1 + ", " + num2 + " and " + num3);
    }

    static void Main(string[] args)
    {
        MethodOverloading2 obj = new MethodOverloading2();

        obj.Display(5);
        obj.Display(5, 100);
        obj.Display(5, 100, 15);
    }
}
