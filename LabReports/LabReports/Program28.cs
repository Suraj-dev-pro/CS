//write a C# program to implement following operator overloading unary minus

using System;

class ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static ComplexNumber operator -(ComplexNumber c)
    {
        return new ComplexNumber(-c.Real, -c.Imaginary);
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

class Program28
{
    static void Main(string[] args)
    {
        ComplexNumber c1 = new ComplexNumber(1, 2);
        Console.WriteLine("c1: " + c1);

        ComplexNumber c2 = -c1;
        Console.WriteLine("c2: " + c2);
    }
}
