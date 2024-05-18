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
    /// The number of nodes in the queue.
    /// </summary>
    private int count;

    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    public class Node
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
        count = 0;
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
        count++;
    }

    /// <summary>
    /// Returns the number of nodes in the queue.
    /// </summary>
    /// <returns>The number of nodes in the queue.</returns>
    public int Count()
    {
        return count;
    }
}