//C# program that will read name of the person from keyboard and display
//the name of its length is less than 10 otherwise throw an exception with suitable message
using System;

class Program45
{
    static void Main()
    {
        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();
        try
        {
            if (name.Length > 10)
            {
                throw new Exception("Name must be less than 10 characters");
            }
            Console.WriteLine($"Name:{name}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
