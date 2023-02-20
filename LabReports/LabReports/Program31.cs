// write a C# program to demonstrate generic class

using System;

class GenericClass<T>
{
    public T generic_var;
    public GenericClass(T gv)
    {
        generic_var = gv;
    }
    public T GenericMethod(T genericParameter)
    {
        Console.WriteLine("Generic Parameter: " + genericParameter);
        Console.WriteLine("Return type of Method: " + typeof(T).ToString());
        return generic_var;
    }
}

class Program31
{
    static void Main()
    {
        GenericClass<int> obj1 = new GenericClass<int>(50);
        obj1.GenericMethod(200);

        GenericClass<string> obj2 = new GenericClass<string>("Hello World");
        obj2.GenericMethod("Hi, this is dot net class");
        Console.ReadKey();
    }
}
