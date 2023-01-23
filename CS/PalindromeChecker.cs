/* write a C# program that reads list of words from a file and 
 * prints the number of words that are palindrome.*/
using System;
using System.IO;
using System.Linq;

class PalindromeChecker
{
    static void Main(string[] args)
    {
        // File path
        string filePath = "/Users/surajkarki/Projects/CS/word.txt";

        // Read all lines from file
        string[] words = File.ReadAllLines(filePath);

        // Count the number of palindrome words
        int count = words.Count(word => IsPalindrome(word));

        // Print the count
        Console.WriteLine("Number of palindrome words: " + count);
    }

    static bool IsPalindrome(string word)
    {
        // Compare the word with its reverse
        return word.SequenceEqual(word.Reverse());
    }
}
