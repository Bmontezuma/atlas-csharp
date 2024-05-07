using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        bool dequeueUsed = false;

        Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Count > 0)
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }

        aQueue.Enqueue(newItem);

        Console.WriteLine($"Queue contains {search}: {aQueue.Contains(search)}");

        if (aQueue.Contains(search))
        {
            while (aQueue.Peek() != search && !dequeueUsed)
            {
                aQueue.Dequeue();
                dequeueUsed = true;
            }
            if (dequeueUsed)
            {
                aQueue.Dequeue();
            }
        }

        return aQueue;
    }
}
