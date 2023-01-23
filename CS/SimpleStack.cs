/* Write a C# program that implements a simple stack.
 * The program should allow user to push elements onto
 * the stack and pop element off the stack
 */
using System;
using System.Collections.Generic;

class SStack
{
    private Stack<int> stack = new Stack<int>();

    public void Push(int value)
    {
        stack.Push(value);
        Console.WriteLine("Pushed: " + value);
    }
    public void Pop()
    {
        if(stack.Count == 0)
        {
            Console.WriteLine(" The stack is empty. ");
            return;
        }

        int value = stack.Pop();
        Console.WriteLine("Popped: " + value);
    }
}
class SimpleStack
{
    static void Main(string[]args)
    {
        SStack sStack = new SStack();

        while(true)
        {
            Console.WriteLine("Enter command(push/pop): ");
            string command = Console.ReadLine();

            if(command.Equals("push"))
            {
                Console.Write("Enter the value to push:");
                int value = int.Parse(Console.ReadLine());
                sStack.Push(value);
            }
            else if(command.Equals("pop"))
            {
                sStack.Pop();
            }
            else
            {
                Console.WriteLine("Invalid Command.");
            }


        }
    }
}


