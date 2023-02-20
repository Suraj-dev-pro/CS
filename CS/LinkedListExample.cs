using System;

class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }
}

class LinkedList
{
    Node head;

    public void Add(int data)
    {
        Node newNode = new Node();
        newNode.Data = data;
        newNode.Next = head;
        head = newNode;
    }

    public void Remove(int data)
    {
        Node current = head;
        if (current != null && current.Data == data)
        {
            head = current.Next;
            return;
        }

        while (current != null && current.Next != null)
        {
            if (current.Next.Data == data)
            {
                current.Next = current.Next.Next;
                return;
            }
            current = current.Next;
        }
    }

    public void PrintList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
    }
}

class LinkedListExample
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        Console.WriteLine("Linked list elements: ");
        list.PrintList();

        list.Remove(3);
        Console.WriteLine("\nLinked list elements after removing 3: ");
        list.PrintList();
    }
}
