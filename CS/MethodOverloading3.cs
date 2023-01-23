//By changing the order of the parameter
using System;
class MethodOverloading3
{
    public void Display(int num)
    {
        Console.WriteLine("The number is: " + num);
    }

    public void Display(int num1, int num2)
    {
        Console.WriteLine("The numbers are: " + num1 + " and " + num2);
    }

    public void Display(int num1, int num3, int num2)
    {
        Console.WriteLine("The numbers are: " + num1 + ", " + num2 + " and " + num3);
    }

    static void Main(string[] args)
    {
        MethodOverloading3 obj = new MethodOverloading3();

        obj.Display(5);
        obj.Display(5, 10);
        obj.Display(5, 10, 15);
    }
}
