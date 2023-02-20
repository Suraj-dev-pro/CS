//C# enumeration ecample changing start index

using System;
public class EnumerationExample1
{
    public enum Season{ Winter=10,Spring,Summer, Fall}

    public static void Main()
    {
        int x = (int)Season.Winter;
        int y = (int)Season.Fall;
        Console.WriteLine("Winter ={0}", x);
        Console.WriteLine("Fall={0}", y);

    }
}