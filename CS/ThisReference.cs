//c# code example this reference 
using System;

class MyClass
{
    public int x;
    public int y;

    public MyClass(int x, int y)
    {
        // Use of "this" reference to differentiate between class variable and constructor parameter
        this.x = x;
        this.y = y;
    }

    public void Display()
    {
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
    }
}

class ThisReference
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass(5, 10);
        obj.Display();
    }
}
