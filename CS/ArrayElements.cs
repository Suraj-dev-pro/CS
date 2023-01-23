// C# program to illustrate the
// Array.Exists(T[], Predicate<T>) Method
using System;

class ArrayElements
{

    // Main method
    static public void Main()
    {

        // Create and initialize array
        string[] language = {"Ruby", "C", "C++", "Java",
                            "Perl", "C#", "Python", "PHP"};

        // Display language array
        Console.WriteLine("Display the array:");
        foreach (string i in language)
        {
            Console.WriteLine(i);
        }

        // Display and check the given elements
        // present in the array or not

        // Using Exists() method
        Console.WriteLine("Is Ruby part of language: {0}",
                        Array.Exists(language, element => element == "Ruby"));

        Console.WriteLine("Is VB part of language: {0}",
                        Array.Exists(language, element => element == "VB"));
    }
}
