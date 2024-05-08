using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList == null || index < 0)
            throw new ArgumentException("Invalid input");

        LinkedListNode<int> current = myLList.First;
        int count = 0;

        // Traverse the list to find the node at the specified index
        while (current != null)
        {
            if (count == index)
            {
                myLList.Remove(current);
                return;
            }
            current = current.Next;
            count++;
        }

        // If the index is out of bounds, throw an exception
        throw new IndexOutOfRangeException("Index out of range");
    }
}
