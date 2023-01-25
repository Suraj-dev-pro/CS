/* A delegate is a type that defines a method signature and is used to encapsulate a method.
 * It allows you to pass methods as arguments to other methods, and to treat them as a type.*/
using System;

delegate int calculator(int n); //declaring delegate
public class DelegateExample
{
    static int number = 1000;
    public static int add(int n)
    {
        number = number + n;
        return number;
    }
    public static int mul(int n)
    {
        number = number * n;
        return number;

    }
    public static int getNumber()
    {
        return number;
    }
    public static void Main()
    {
        calculator c1 = new calculator(add);//instantiating delegate
        calculator c2 = new calculator(mul);

        c1(20); //calling method using delegate
        Console.WriteLine("After c1 delegate Number is: " + getNumber());

        c2(3);
        Console.WriteLine("After c2 delegate Number is: " + getNumber());
    }

         
}