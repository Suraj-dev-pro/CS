//C# program Dictonary<Tkey,Tvalue>

using System;
using System.Collections.Generic;

class Program33
{
    static void Main()
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "one");
        dict.Add(2, "two");
        dict.Add(3, "three");
        dict.Add(4, "four");

        Console.WriteLine("Print the content of the dictionary");
        Console.WriteLine("The total count of dictionary is:{0}", dict.Count());
        foreach(KeyValuePair<int,string> item in dict)
        {
            Console.WriteLine("key={0} value={1}", item.Key, item.Value);
        }
        Console.WriteLine("remove any one value of dictionary");
        dict.Remove(3);
        foreach(var item1 in dict)
        {
            Console.WriteLine("the key ={0} and value={1}", item1.Key, item1.Value);
        }
        Console.ReadKey();
    }
}