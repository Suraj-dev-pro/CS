// C# program to display Employee records in descending order to employee name using Linq
using System;
using System.Linq;

class Employees
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
}

class LinqPrac
{
    static void Main(string[] args)
    {
        Employees[] employees = new Employees[]
        {
            new Employees { Name = "John", Age = 25, Department = "IT" },
            new Employees { Name = "Mike", Age = 30, Department = "HR" },
            new Employees { Name = "Sara", Age = 35, Department = "IT" },
            new Employees { Name = "Bob", Age = 40, Department = "Finance" },
            new Employees { Name = "Jessica", Age = 45, Department = "Marketing" }
        };

        // Use LINQ to sort the employees by Name in descending order
        var sortedEmployees = from e in employees
                              orderby e.Name descending
                              select e;

        // Display the sorted employees
        Console.WriteLine("Employee records in descending order with respect to employee name:");
        foreach (var employee in sortedEmployees)
        {
            Console.WriteLine("Name: " + employee.Name + ", Age: " + employee.Age + ", Department: " + employee.Department);
        }
    }
}
