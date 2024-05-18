// queue.cs
using System;

public class Queue<T>
{
    // Method to return the type of the queue
    public Type CheckType()
    {
        return typeof(T);
    }
}
