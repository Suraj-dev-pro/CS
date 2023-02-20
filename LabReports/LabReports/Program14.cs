//Write a C# program to find the sum of diagonal elements of 3*3 matrix
using System;

class Program14
{
    static void Main()
    {
        int[,] matrix= new int[3, 3];
        Console.WriteLine("Enter the value of the matrix:");

        for(int i =0;i<3;i++)
        {
            for(int j =0;j<3;j++)
            {
                Console.WriteLine("matrix[{0},{1}]=",i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if(i == j)
                {
                    sum += matrix[i, j];
                }

            }
        }
        Console.WriteLine("sum of diagonal elements:" + sum);
    }
}