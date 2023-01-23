/* Method overloading by changing the number of parameters*/
using System;

class MethodOverloading1
{
    public void Display(int num)
    {
        Console.WriteLine("The number is: " + num);
    }

    public void Display(int num1, int num2)
    {
        Console.WriteLine("The numbers are: " + num1 + " and " + num2);
    }

    public void Display(int num1, int num2, int num3)
    {
        Console.WriteLine("The numbers are: " + num1 + ", " + num2 + " and " + num3);
    }

    static void Main(string[] args)
    {
        MethodOverloading1 obj = new MethodOverloading1();

        obj.Display(5);
        obj.Display(5, 10);
        obj.Display(5, 10, 15);
    }
}

