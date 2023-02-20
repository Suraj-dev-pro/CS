//C#,generic method is a method that is defined with a type parameter
using System;

class GenericClassE
{
    public void Show<T>(T msg)
    {
        Console.WriteLine(msg);
    }  
}
class GenericMethod
{
    static void Main()
    {
        GenericClassE genC = new GenericClassE();
        genC.Show(" this is generic Method ");
        genC.Show(101);
        genC.Show("I");
    }
}
