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
        // Test cases
        TestQueue(new Queue<string>(new string[] { "C", "HTML", "Javascript", "Python", "React", "Ruby" }), "C#", "Javascript");
        TestQueue(new Queue<string>(new string[] { "Cohort 0", "Cohort 1", "Cohort 2", "Cohort 3", "Cohort 4", "Cohort 5", "Cohort 6", "Cohort 7" }), "Cohort 8", "Cohort 5");
        TestQueue(new Queue<string>(new string[] { "C", "HTML", "Javascript", "Python", "React", "Ruby" }), "C#", "C++");
        TestQueue(new Queue<string>(), "C#", "C++");
    }

    static void TestQueue(Queue<string> queue, string newItem, string search)
    {
        Console.WriteLine($"Case: Queue: {string.Join(", ", queue)} // Add: {newItem} // Search: {search}");
        MyQueue.Info(queue, newItem, search);
        Console.WriteLine();
    }
}
