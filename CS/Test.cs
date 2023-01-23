// A constructor which has parameters is called parameterized constructor.
// It is used to provide different values to distict objects.
using System;
public class Employee
{
    public int id;
    public String name;
    public float salary;
    public Employee(int i, String n, float s)
    {
        id = i;
        name = n;
        salary = s;
    }
    public void Display()
    {
        Console.WriteLine(id + " " + name + " " + salary);
    }
}
class Test
{
    public static void Main(string[]args)
    {
        Employee e1 = new Employee(101, "Ramesh", 890000f);
        Employee e2 = new Employee(102, "Suresh", 490000f);
        e1.Display();
        e2.Display();
    }
}
