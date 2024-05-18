using System;

/// <summary>
/// Represents a generic queue.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// The head node of the queue.
    /// </summary>
    private Node head;

    /// <summary>
    /// The tail node of the queue.
    /// </summary>
    private Node tail;

    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    private class Node
    {
        /// <summary>
        /// The value of the node.
        /// </summary>
        public T Value;

        /// <summary>
        /// The next node in the queue.
        /// </summary>
        public Node Next;

        /// <summary>
        /// Initializes a new instance of the Node class.
        /// </summary>
        /// <param name="value">The value of the node.</param>
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    /// <summary>
    /// Returns the type of the queue's elements.
    /// </summary>
    /// <returns>The type of the elements in the queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Initializes a new instance of the Queue class.
    /// </summary>
    public Queue()
    {
        head = null;
        tail = null;
    }

    /// <summary>
    /// Adds an element to the end of the queue.
    /// </summary>
    /// <param name="item">The element to add.</param>
    public void Enqueue(T item)
    {
        Node newNode = new Node(item);
        if (tail == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
    }

    /// <summary>
    /// Removes and returns the element at the beginning of the queue.
    /// </summary>
    /// <returns>The element at the beginning of the queue.</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        T value = head.Value;
        head = head.Next;
        if (head == null)
        {
            tail = null;
        }
        return value;
    }

    /// <summary>
    /// Returns the element at the beginning of the queue without removing it.
    /// </summary>
    /// <returns>The element at the beginning of the queue.</returns>
    public T Peek()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return head.Value;
    }

    /// <summary>
    /// Determines whether the queue is empty.
    /// </summary>
    /// <returns>true if the queue is empty; otherwise, false.</returns>
    public bool IsEmpty()
    {
        return head == null;
    }
}