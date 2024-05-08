using System;
using System.Collections.Generic;

namespace OrderedLinkedList
{
    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
        }
    }

    public class LinkedList<T> where T : IComparable
    {
        public LinkedListNode<T> First { get; private set; }

        public void Add(T value)
        {
            if (First == null)
            {
                First = new LinkedListNode<T>(value);
                return;
            }

            LinkedListNode<T> current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new LinkedListNode<T>(value);
        }

        public static LinkedListNode<T> Insert(LinkedList<T> myLList, T n)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(n);
            if (myLList.Count == 0 || n.CompareTo(myLList.First.Value) <= 0)
            {
                newNode.Next = myLList.First;
                myLList.First = newNode;
                return newNode;
            }

            LinkedListNode<T> current = myLList.First;
            while (current.Next != null && current.Next.Value.CompareTo(n) < 0)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
            return newNode;
        }

        public int Count
        {
            get
            {
                int count = 0;
                LinkedListNode<T> current = First;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }
    }
}
