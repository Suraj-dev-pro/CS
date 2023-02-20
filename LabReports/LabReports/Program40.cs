//event handling using delegate
using System;

delegate void EventHandler(string Message);

class Program40
{
    static event EventHandler onEvent;
    static void Main(string[]args)
    {
        onEvent += HandleEvent;
        onEvent("something Happened!");
    }
    static void HandleEvent(string Message)
    {
        Console.WriteLine(Message);
    }


}