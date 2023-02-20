//C# enumeration example
using System;
public class EmptyEnumeration
{
    public enum season{ Winter, Summer,Spring, Fall}
    public static void Main(string[]args)
    {
        int x = (int)season.Winter;
        int y = (int)season.Fall;

        Console.WriteLine("Winter={0}", x);
        Console.WriteLine("Fall={0}", y);
    }
}