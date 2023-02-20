//Write a c# program to illustrate inheritance of single-level
using System;

class Parent
{
    public string name;
    public int age;
    public void PrintInfo()
    {
        Console.WriteLine("Name" + name);
        Console.WriteLine("Age" + age);
    }
}
class child:Parent
{
    public string school;
    public void PrintSchool()
    {
        Console.WriteLine("School:" + school);
    }
}
class Program22
{
    static void Main()
    {
        child childr = new child();
        childr.name = "John";
        childr.age = 20;
        childr.school = "HEBS";
        childr.PrintInfo();
        childr.PrintSchool();
    }
}