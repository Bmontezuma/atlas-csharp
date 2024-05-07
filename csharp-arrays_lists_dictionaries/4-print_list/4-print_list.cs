using System;
using System.Linq;
using System.Collections.Generic;

class List 
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> newList = Enumerable.Range(0, size).ToList();
        Console.WriteLine(string.Join(" ", newList));
        Console.WriteLine($"List Length: {newList.Count}");
        Console.WriteLine($"List Length: {newList.Count}"); // New line added
        return newList;
    }
}
