using System;
using System.Linq;
using System.Collections.Generic;

class List 
{
    public static List<int> CreatePrint(int size, int printCount = 1)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> newList = Enumerable.Range(0, size).ToList();
        Console.WriteLine(string.Join(" ", newList));
        for (int i = 0; i < printCount; i++)
        {
            Console.WriteLine($"List Length: {newList.Count}");
        }
        return newList;
    }
}
