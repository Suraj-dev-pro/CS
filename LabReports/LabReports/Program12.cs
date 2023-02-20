//Find the minimum and maximum elements in an array in C#
using System;

public class Program12
{
    public static void Main()
    {
        int[] arr = new int[100];
        int i, mx, mn, n;

        Console.WriteLine("Find the minimum and maximum elements in an array");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Enter the number of elements in the array: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input {0} elements of the array:", n);
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Element {0}:", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        mx = arr[0];
        mn = arr[0];
        for (i = 1; i < n; i++)
        {
            if (arr[i] > mx)
            {
                mx = arr[i];
            }
            if (arr[i] < mn)
            {
                mn = arr[i];
            }
        }
        Console.WriteLine("Maximum element is: {0}", mx);
        Console.WriteLine("Minimum element is: {0}", mn);
    }
}
