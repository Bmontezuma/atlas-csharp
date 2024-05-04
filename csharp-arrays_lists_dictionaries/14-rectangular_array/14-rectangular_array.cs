using System;

class Program
{
    static void Main(string[] args)
    {
        int size = 5;
        int[,] array2D = new int[size, size];

        // Initialize index [2,2] to 1
        array2D[2, 2] = 1;

        // Print the 2D array
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(array2D[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
