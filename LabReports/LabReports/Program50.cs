//example C# linq method
using System;
using System.Collections.Generic;
using System.Linq;

public class Program50
{
    public static void Main()
    {
        //string collection

        List<string> stringlist = new List<string> ()
            {
                "C# Tutorials",
                "Python Tutorials",
                "Learn CSS",
                "Java",
                "Learn C++"

        };
        //LINQ method syntax
        var result = stringlist.Where(s => s.Contains("Tutorials"));

        foreach(var str in result)
        {
            Console.WriteLine(str);
        }

    }
}