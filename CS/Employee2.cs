// A constructor which has no argument is known as default constructor.
// It is invoked at the time of creating ojects
using System;
public class Employee2
{
    public Employee2()
    {
        Console.WriteLine("Default Constructor Invoked");
    }
    public static void Main(string[]args)
    {
        Employee2 e1 = new Employee2();
        Employee2 e2 = new Employee2();
    }

    internal void display()
    {
        throw new NotImplementedException();
    }
}