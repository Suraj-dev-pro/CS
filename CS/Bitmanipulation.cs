using System;

class BitManipulation
{
    static void Main(string[] args)
    {
        int num = 5;
        Console.WriteLine("Original number: " + num);

        // Left shift
        int leftShifted = num << 1;
        Console.WriteLine("Left shifted: " + leftShifted);

        // Right shift
        int rightShifted = num >> 1;
        Console.WriteLine("Right shifted: " + rightShifted);

        // Bitwise AND
        int num1 = 25, num2 = 15;
        int result = num1 & num2;
        Console.WriteLine("Bitwise AND: " + result);

        // Bitwise OR
        result = num1 | num2;
        Console.WriteLine("Bitwise OR: " + result);

        // Bitwise XOR
        result = num1 ^ num2;
        Console.WriteLine("Bitwise XOR: " + result);

        // Bitwise NOT
        int notNum = ~num;
        Console.WriteLine("Bitwise NOT: " + notNum);
    }
}
