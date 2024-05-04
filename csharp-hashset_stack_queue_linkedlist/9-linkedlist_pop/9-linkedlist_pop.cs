using System;
using System.Collections.Generic;

public static class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
        {
            return 0;
        }

        LinkedListNode<int> headNode = myLList.First;
        int headValue = headNode.Value;

        myLList.RemoveFirst();

        return headValue;
    }
}
