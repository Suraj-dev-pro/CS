//Arithmetic Exception DivideByZeroException

using System;
class Program41
{
    static void Main(string[]args)
    {
        try
        {
            int x = 10;
            int y = 0;
            int result = x / y;
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Divsion by zero is not allowed ");
        }
    }
}
