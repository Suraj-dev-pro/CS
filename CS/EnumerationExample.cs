//Enumeration example in c# traversing all values using geatValues()

using System;
public class EnumerationExample
{
    public enum Days{ sun,mon,tue,wed,thu,fri,sat}
    public static void Main()
    {
        foreach(Days d in Enum.GetValues(typeof(Days)))
        {
            Console.WriteLine(d);
        }
    }
}