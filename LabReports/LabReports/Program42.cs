//Arithmetic Exception IndexOutOfRangeException
using System;
class Program42
{
static void Main()
    {
        try
        {
            int[] arr= new int[6];
            arr[7] = 200;
            Console.WriteLine("Array Value:" + arr[7]);
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("finally blocked");
        }
    }
}