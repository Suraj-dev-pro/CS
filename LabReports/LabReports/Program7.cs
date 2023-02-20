//Write a C# program to check whether the input chracter is a vowel or not using switch cases statement

using System;

class Program7
{
    static void Main()
    {
        char ch;
        Console.WriteLine("Enter the character to check if it's a vowel");
        ch = Char.Parse(Console.ReadLine());
        Console.WriteLine("Checking character...\n");
        switch (ch)
        {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'i':
            case 'I':
            case 'o':
            case 'O':
            case 'u':
            case 'U':
                Console.WriteLine("{0} is a vowel", ch);
                break;

            default:
                Console.WriteLine("{0} is not a vowel", ch);
                break;
        }
        Console.ReadKey();
    }
}
