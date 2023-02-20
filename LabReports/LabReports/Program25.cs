//write a C# program to illustrate multiple interface using interface
using System;

interface Ishape
{
    void Draw();
}

interface Icolor
{
    void Fill();
}

class Circlee : Ishape, Icolor
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }

    public void Fill()
    {
        Console.WriteLine("Filling a circle with color");
    }
}

class Program25
{
    static void Main()
    {
        Circlee circle = new Circlee();
        circle.Draw();
        circle.Fill();
    }
}
