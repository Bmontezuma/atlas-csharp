using System;
using System.Collections.Generic;
using System.Linq;

public class List
{
    public static List<int> CreateAndPrintIntegerList(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        var list = Enumerable.Range(0, size).ToList();

        Console.WriteLine(string.Join(" ", list));

        return list;
    }

    public static void Main(string[] args)
    {
        List<int> myList = CreateAndPrintIntegerList(10);
        if (myList!= null)
        {
            Console.WriteLine("List created successfully");
        }
    }
}
