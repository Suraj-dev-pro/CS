// C# program to show working of
// user defined Generic classes
using System;

// We use < > to specify Parameter type
public class Generic<T>
{

    // private data members
    private T data;

    // using properties
    public T value
    {

        // using accessors
        get
        {
            return this.data;
        }
        set
        {
            this.data = value;
        }
    }
}

// Driver class
class GenericClass
{

    // Main method
    static void Main(string[] args)
    {

        // instance of string type
        Generic<string> name = new Generic<string>();
        name.value = "GeeksforGeeks";

        // instance of float type
        Generic<float> version = new Generic<float>();
        version.value = 5.0F;

        // display GeeksforGeeks
        Console.WriteLine(name.value);

        // display 5
        Console.WriteLine(version.value);
    }
}
