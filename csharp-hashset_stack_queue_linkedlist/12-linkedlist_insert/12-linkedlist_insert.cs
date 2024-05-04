using System;
using System.Collections.Generic;

public static class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        if (myLList.Count == 0)
        {
            myLList.AddFirst(newNode);
            return newNode;
        }

        LinkedListNode<int> currentNode = myLList.First;
        LinkedListNode<int> previousNode = null;

        while (currentNode != null && currentNode.Value < n)
        {
            previousNode = currentNode;
            currentNode = currentNode.Next;
        }

        if (currentNode == null)
        {
            myLList.AddLast(newNode);
        }
        else
        {
            newNode.Next = currentNode;
            previousNode.Next = newNode;
        }

        return newNode;
    }
}
