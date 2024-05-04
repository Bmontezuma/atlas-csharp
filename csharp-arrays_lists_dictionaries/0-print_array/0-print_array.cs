using System;
using System.Linq;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Incorrect input");
            return null;
        }
        else if (size == 0)
        {
            Console.WriteLine("Empty array");
            return new int[0];
        }

        int[] nums = Enumerable.Range(1, size).ToArray();
        Console.WriteLine("Array elements:");
        Console.WriteLine(string.Join(" ", nums));
        return nums;
    }
}
