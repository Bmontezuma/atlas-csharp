using System;
using System.Collections.Generic;

public static class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> list = new List<int>(size);

        for (int i = 0; i < size; i++)
        {
            list.Add(i);
            Console.Write(i + " ");
        }

        Console.WriteLine();
        return list;
    }
}
