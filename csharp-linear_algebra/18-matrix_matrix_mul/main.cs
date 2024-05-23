using System;

class Program
{
    static void Main()
    {
        // Example usage:
        double[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        double angleInRadians = Math.PI / 4; // 45 degrees

        // Rotate the matrix
        double[,] rotatedMatrix = MatrixMath.Rotate2D(matrix, angleInRadians);

        // Display the rotated matrix
        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        Console.WriteLine("\nRotated Matrix:");
        PrintMatrix(rotatedMatrix);
    }

    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],8}");
            }
            Console.WriteLine();
        }
    }
}
