using System;
using System.Collections.Generic;

public class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList == null)
        {
            throw new ArgumentNullException(nameof(myLList), "List cannot be null.");
        }

        if (index < -1 || index >= myLList.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        if (myLList.Count == 0)
        {
            throw new InvalidOperationException("List is empty.");
        }

        if (index == 0)
        {
            myLList.RemoveFirst();
            return;
        }

        LinkedListNode<int> current = myLList.First;
        for (int i = 0; i < index - 1; i++)
        {
            if (current == null)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            current = current.Next;
        }

        if (current != null && current.Next != null)
        {
            current.Next = current.Next.Next;
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
    }
}
