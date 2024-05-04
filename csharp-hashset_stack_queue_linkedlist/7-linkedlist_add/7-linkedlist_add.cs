using System;
using System.Collections.Generic;

public static class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        if (myLList.Count > 0)
        {
            newNode.Next = myLList.First;
            myLList.First = newNode;
        }
        else
        {
            myLList.AddFirst(newNode);
        }

        return newNode;
    }
}
