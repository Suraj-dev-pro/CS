// write a c# program to ask user to enter name and age if the age entered is less than 18 the program should
// display name of the user saying minor else should display name saying adult.

using System;

class AdultChild
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter Your Name");
        string name = Console.ReadLine();

        Console.WriteLine("Please Enter Your Age");
        int age = int.Parse(Console.ReadLine());

        if (age < 18)
        {
            Console.WriteLine(name + " is minor");
        }
        else
        {
            Console.WriteLine(name + " is adult");

        }

    }
}