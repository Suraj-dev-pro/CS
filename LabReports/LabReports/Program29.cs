//c# program to binary + and - overloading
using System;
class complex1
{
    public int realn, imga;
    
    public complex1(int r,int i)
    {
        realn = r;
        imga = i;
    }
    public void display()
    {
        Console.WriteLine(realn + "+" + imga + "i");
    }
    public static complex1 operator +(complex1 c1,complex1 c2)
    {
        complex1 temp = new complex1(0, 0);
        temp.realn = c1.realn + c2.realn;
        temp.imga = c1.imga + c2.imga;
        return temp;
    }
    public static complex1 operator -(complex1 c1,complex1 c2)
    {
        complex1 temp = new complex1(0, 0);
        temp.realn = c1.realn - c2.realn;
        temp.imga = c1.imga + c2.imga;
        return temp;
    }
}
class Program29
{
    static void Main()
    {
        complex1 c1 = new complex1(5,6);
        complex1 c2 = new complex1(7, 8);
        complex1 c3 = c1 + c2;
        complex1 c4 = c1 - c2;

        Console.WriteLine("sum of two complex number:");
        c3.display();
        Console.WriteLine("subtraction of twro complex number: ");
        c4.display();
    }
}