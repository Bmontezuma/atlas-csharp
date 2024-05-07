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

        var ls = Enumerable.Range(0, size).ToList();
        Console.WriteLine(string.Join(" ", ls));

        Console.WriteLine("List Length: " + ls.Count);

        return ls;
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
