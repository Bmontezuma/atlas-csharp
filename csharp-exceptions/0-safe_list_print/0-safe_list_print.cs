using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {1, 2, 3, 4, 5};
        int count;

        count = List.SafePrint(myList, myList.Count);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count - 2);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count + 2);
        Console.WriteLine("Number of integers printed: " + count);
    }
}

public static class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        try
        {
            // Check if the list is null
            if (myList == null)
            {
                throw new ArgumentNullException(nameof(myList), "List cannot be null");
            }

            // Use Math.Min to ensure we don't go out of bounds
            int elementsToPrint = Math.Min(n, myList.Count);

            for (int i = 0; i < elementsToPrint; i++)
            {
                Console.Write(myList[i] + " ");
                count++;
            }
            Console.WriteLine(); // Add a newline after printing
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        return count;
    }
}
