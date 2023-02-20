//Write a C# program to multiply two 3*3 matrix and display resultant matrix
using System;

class Program13
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = new int[3, 3];
            int[,] secondMatrix = new int[3, 3];
            int[,] resultMatrix = new int[3, 3];

            Console.WriteLine("Enter elements of first 3x3 matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter element [" + (i + 1) + "," + (j + 1) + "]: ");
                    firstMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements of second 3x3 matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter element [" + (i + 1) + "," + (j + 1) + "]: ");
                    secondMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
            }

            Console.WriteLine("Resultant matrix is:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
  }

