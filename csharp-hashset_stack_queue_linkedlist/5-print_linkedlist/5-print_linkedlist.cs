using System;
using System.Collections.Generic;

public static class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        if (size < 0)
            return myLList;

        for (int i = 0; i < size; i++)
        {
            myLList.AddLast(i);
            Console.Write(i + " ");
        }
        Console.WriteLine();

        return myLList;
    }
}
