//write a c# program to select students who live in kirtipur and studied in patan multple campus using linq
using System;
using System.Linq;
using System.Collections.Generic;

class Students
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Campus { get; set; }
    }
class Program53
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>()
            {
                new Students { Name = "John", Address = "Kirtipur", Campus = "Patan Multiple Campus" },
                new Students { Name = "Jane", Address = "Kirtipur", Campus = "Central Campus" },
                new Students { Name = "Jim", Address = "Bhaktapur", Campus = "Patan Multiple Campus" },
                new Students { Name = "Joan", Address = "Lalitpur", Campus = "Patan Multiple Campus" }
            };

            var selectedStudents = from student in students
                                   where student.Address == "Kirtipur" && student.Campus == "Patan Multiple Campus"
                                   select student;

            Console.WriteLine("Selected Students:");
            foreach (var student in selectedStudents)
            {
                Console.WriteLine("Name: {0}, Address: {1}, Campus: {2}", student.Name, student.Address, student.Campus);
            }

            Console.ReadLine();
        }
    }
