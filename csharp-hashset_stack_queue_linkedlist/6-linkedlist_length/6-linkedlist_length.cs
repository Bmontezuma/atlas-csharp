using System;
using System.Collections.Generic;

public static class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int length = 0;

        foreach (int item in myLList)
        {
            length++;
        }

        return length;
    }
}
