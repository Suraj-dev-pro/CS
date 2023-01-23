// C# code to Get the number of
// elements contained in the Queue
using System;
using System.Collections;

class NoOfQueue
{

    // Driver code
    public static void Main()
    {

        // Creating a Queue
        Queue myQueue = new Queue();

        // Inserting the elements into the Queue
        myQueue.Enqueue("Chandigarh");
        myQueue.Enqueue("Delhi");
        myQueue.Enqueue("Noida");
        myQueue.Enqueue("Himachal");
        myQueue.Enqueue("Punjab");
        myQueue.Enqueue("Jammu");

        // Displaying the count of elements
        // contained in the Queue
        Console.Write("Total number of elements in the Queue are : ");

        Console.WriteLine(myQueue.Count);
    }
}
