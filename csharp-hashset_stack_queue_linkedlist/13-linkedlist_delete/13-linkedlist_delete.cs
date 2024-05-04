using System;
using System.Collections.Generic;

public static class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        if (index == 0)
        {
            myLList.RemoveFirst();
            return;
        }

        LinkedListNode<int> currentNode = myLList.First;
        for (int i = 0; i < index - 1; i++)
        {
            currentNode = currentNode.Next;
        }

        LinkedListNode<int> nodeToRemove = currentNode.Next;
        currentNode.Next = currentNode.Next.Next;
        nodeToRemove.Value = default;
    }
}
