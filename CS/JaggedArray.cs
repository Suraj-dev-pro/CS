//C# creating jagged array example
using System;

class JaggedArray
{
    static void Main(string[] args)
    {
        // Declare a jagged array of 3 int arrays
        int[][] jaggedArray = new int[3][];

        // Initialize the first array
        jaggedArray[0] = new int[] { 1, 2, 3 };

        // Initialize the second array
        jaggedArray[1] = new int[] { 4, 5 };

        // Initialize the third array
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Print out the jagged array
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
