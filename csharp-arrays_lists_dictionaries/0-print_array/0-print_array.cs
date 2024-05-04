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
            Console.WriteLine("Array Length: 0");
            return new int[0];
        }
        else
        {
            int[] nums = Enumerable.Range(1, size).ToArray();
            Console.WriteLine("Array elements:");
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine("Array Length: " + nums.Length);
            return nums;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] newArray;

        // Case: Positive size
        Console.WriteLine("Correct output - case: positive size");
        newArray = Array.CreatePrint(5);
        Console.WriteLine("----------------");

        // Case: Size of 0
        Console.WriteLine("Correct output - case: size of 0");
        newArray = Array.CreatePrint(0);
        Console.WriteLine("----------------");

        // Case: Negative size
        Console.WriteLine("Correct output - case: negative size");
        newArray = Array.CreatePrint(-5);
        Console.WriteLine("----------------");
    }
}
