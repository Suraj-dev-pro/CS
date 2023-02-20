//write a c# program to illustrate concept of static class and static constructor
using System;
static class utility
{
    //static field
    public static int count = 0;
    //static constructor
    static utility()
    {
        Console.WriteLine("Static Constructor called.");
    }
    //static Method
    public static void IncrementCount()
    {
        count++;
    }
}
class Program20
{
    static void Main(string[]args)
    {
        //access static field and method
        utility.count++;
        utility.IncrementCount();
        Console.WriteLine("Count: " + utility.count);
    }
}