using System;

public class Employee1
{
    public Employee1()
    {
        Console.WriteLine("Constructor Invoked");
    }
    ~Employee1()
    {
        Console.WriteLine("Destructor Invoked");
    }
}
class Test2
{
    public static void Main(string[] args)
    {
        Employee1 e1 = new Employee1();
    }
}