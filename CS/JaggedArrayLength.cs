//C# counting the length of jagged array
using System;

class JaggedArrayLegth
{
    static void Main()
    {
        //Declare jagged array of three int arrays
        int[][] jagged_arr = new int[3][];

        //initialize the first array
        jagged_arr[0] = new int[] { 1, 4, 5 };
        //initialize the second array
        jagged_arr[1] = new int[] { 7, 8, 0, 1 };
        //initialize the third array
        jagged_arr[2] = new int[] { 9, 1 };

        Console.WriteLine("The length of the jagged array " + jagged_arr.Length);
    }
}