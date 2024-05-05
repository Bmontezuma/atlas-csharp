using System;
using System.Collections.Generic;

public static class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        if (list1.Count < listLength || list2.Count < listLength)
        {
            Console.WriteLine("Out of range");
            return new List<int>();
        }

        List<int> result = new List<int>(listLength);

        try
        {
            for (int i = 0; i < listLength; i++)
            {
                result.Add(list1[i] / list2[i]);
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
            result.Clear();
        }

        return result;
    }
}
