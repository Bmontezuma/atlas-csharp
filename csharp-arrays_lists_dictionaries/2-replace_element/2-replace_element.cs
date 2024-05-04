using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return array; // return the unchanged array if index is out of range
        }

        array[index] = n; // replace the element at the specified index
        return array;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] array = {0, 1, 2, 3, 4, 5, 6};

        PrintArray(array);
        Array.ReplaceElement(array, 1, 98);
        PrintArray(array);
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
