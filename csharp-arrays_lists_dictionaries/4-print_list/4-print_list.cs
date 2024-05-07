using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        var newList = Enumerable.Range(0, size).ToList();
        Console.WriteLine(string.Join(" ", newList));

        Console.WriteLine($"List Length: {newList.Count}");

        return newList;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> newList;

        newList = List.CreatePrint(10);
        Console.WriteLine("----------------");

        newList = List.CreatePrint(16);
        Console.WriteLine("----------------");

        newList = List.CreatePrint(0);
        Console.WriteLine("----------------");

        newList = List.CreatePrint(1);
        Console.WriteLine("----------------");

        newList = List.CreatePrint(-98);
    }
}
