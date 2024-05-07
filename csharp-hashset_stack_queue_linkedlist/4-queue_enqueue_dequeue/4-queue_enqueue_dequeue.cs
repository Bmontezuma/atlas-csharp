using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        bool hasSearch = aQueue.Contains(search);

        Console.WriteLine("Number of items: {0}", aQueue.Count);
        Console.WriteLine("{0}", aQueue.Count == 0 ? "Queue is empty" : string.Format("First item: {0}", aQueue.Peek()));

        aQueue.Enqueue(newItem);

        Console.WriteLine("Queue contains \"{0}\": {1}", search, hasSearch);

        if (hasSearch)
        {
            int upTo = 0;
            foreach (string i in aQueue)
            {
                upTo++;
                if (i == search)
                    break;
            }
            for (int i = 0; i < upTo; i++)
            {
                aQueue.Dequeue();
            }
        }
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
