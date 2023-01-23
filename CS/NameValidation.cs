/*C# program  that will read name from keyboard and 
 * display it on screen.The Program should throw an exception 
 * when length of name is more that 10 characters*/
using System;

class NameValidation
{
    static void Main()
    {
        Console.WriteLine("Please Enter you Name");
        string name = Console.ReadLine();
        try
        {
            if (name.Length > 10)
            {
                throw new Exception("Name cannot be of characters more tha 10");
            }
            Console.WriteLine("Your Name is " + name);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

}
