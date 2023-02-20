//C# InvalidCastException

using System;

class Program43
{
    static void Main()
    {
        object obj = "Hello world";
        try
        {
            int x = (int)obj;
        }
        catch(InvalidCastException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}