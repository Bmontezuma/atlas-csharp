using System;

public static class Array
{
    public static void Reverse(int[] array)
    {
        int length = array.Length;

        for (int i = length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}
