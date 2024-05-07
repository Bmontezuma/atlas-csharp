using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print the number of items in the queue
        Console.WriteLine($"Number of items: {aQueue.Count}");

        // Print the item at the top of the queue without removing it
        if (aQueue.Count > 0)
            Console.WriteLine($"First item: {aQueue.Peek()}");
        else
            Console.WriteLine("Queue is empty");

        // Add a new item to the queue
        aQueue.Enqueue(newItem);

        // Print if the queue contains the given item
        Console.WriteLine($"Queue contains \"{search}\": {aQueue.Contains(search)}");

        // Remove items up to and including the given item, if it exists
        while (aQueue.Count > 0 && aQueue.Peek() != search)
            aQueue.Dequeue();

        return aQueue;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue<string> aQueue = new Queue<string>();

        aQueue.Enqueue("C");
        aQueue.Enqueue("HTML");
        aQueue.Enqueue("Javascript");
        aQueue.Enqueue("Python");
        aQueue.Enqueue("React");
        aQueue.Enqueue("Ruby");

        foreach (string item in aQueue)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyQueue.Info(aQueue, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aQueue)
            Console.WriteLine(item);
    }
}
