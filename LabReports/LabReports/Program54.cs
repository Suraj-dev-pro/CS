//Write a C# program to display employee records in descending order with 
//respect to employee name using linq
using System;
using System.Linq;
using System.Collections.Generic;

    class Employees
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }

    class Program54
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>()
            {
                new Employees { Name = "John", Age = 35, Department = "HR" },
                new Employees { Name = "Jane", Age = 40, Department = "IT" },
                new Employees { Name = "Jim", Age = 30, Department = "Marketing" },
                new Employees { Name = "Joan", Age = 25, Department = "Sales" }
            };

            var sortedEmployees = employees.OrderByDescending(e => e.Name);

            Console.WriteLine("Employee Records (Sorted by Name in Descending Order):");
            foreach (var employee in sortedEmployees)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Department: {2}", employee.Name, employee.Age, employee.Department);
            }

            Console.ReadLine();
        }
    }
