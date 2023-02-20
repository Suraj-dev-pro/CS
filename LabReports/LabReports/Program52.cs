//Example in C# where condition with object class

using System;
using System.Linq;
using System.Collections.Generic;

public class Employee
{
    public int eid { get; set; }
    public string name { get; set; }
    public string address { get; set; }
    public double salary { get; set; }

    public Employee(int id, string n, string a, double s)
    {
        this.eid = id;
        this.name = n;
        this.address = a;
        this.salary = s;
    }
}

class Program52
{
    static void Main()
    {
        List<Employee> elist = new List<Employee>
        {
            new Employee(101,"Suraj","Chatara",500000),
            new Employee(102, "Saroj", "Dharan", 300000),
            new Employee(103,"Rojan","Ithari",400000),
            new Employee(104,"Sargam","Ktm",200000)
        };
        var emp = elist.Where(e => e.address == "Ktm" && e.salary > 200000);
        Console.WriteLine("Employee information whose address is Ktm and salary is greater than 400000");
        foreach (var em in emp)
        {
            Console.WriteLine(em.eid + " " + em.name + " " + em.address + " " + em.salary);
        }

    }
}
