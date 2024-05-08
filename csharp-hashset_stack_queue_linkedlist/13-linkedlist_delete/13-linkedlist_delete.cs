using System;
using System.Collections.Generic;

public class LList
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

        LinkedListNode<int> current = myLList.First;
        for (int i = 0; i < index - 1; i++)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        current.Next = current.Next.Next;
    }
}
