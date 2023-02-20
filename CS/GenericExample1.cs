//example generic class c#

using System;

class GenericClass<T>
{
    public GenericClass(T msg)
    {
        Console.WriteLine(msg);
    }
}
class GenericExample1
{
    static void Main(string[] args)
    {
        GenericClass<string> gen = new GenericClass<string>("This is generic class");
        GenericClass<int> getI = new GenericClass<int>(101);
        GenericClass<char> getch = new GenericClass<char>('I');
    }
}
