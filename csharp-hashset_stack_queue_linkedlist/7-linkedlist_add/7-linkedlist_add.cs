using System;
using System.Collections.Generic;

public static class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = myLList.AddFirst(n);
        return newNode;
    }
}
