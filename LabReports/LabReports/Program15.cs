/* Write a C# program to initialize following matrix and display the matrix with sum of individual row
10 20 30 40 50
60 70 80
90
100 120
*/
using System;
class Program15
{
    static void Main()
    {
        int[][] matrix = {
            new int[] { 10, 20, 30, 40, 50 },
            new int[] { 60, 70, 80 },
            new int[] { 90 },
            new int[] { 100, 120 }
        };
        int rows = matrix.Length;
        for (int i = 0; i < rows; i++)
        {
            int rowsum = 0;
            int cols = matrix[i].Length;
            for (int j = 0; j < cols; j++)
            {
                rowsum += matrix[i][j];
                Console.WriteLine(matrix[i][j] + "");
            }
            Console.WriteLine("sum: " + rowsum);
        }
    }
}