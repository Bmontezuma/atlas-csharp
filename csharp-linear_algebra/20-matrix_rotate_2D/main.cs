using System;
using MatrixMath;

class Program
{
    static void Main(string[] args)
    {
        Test(new double[,] { { -1, 2 }, { 4, 6 } }, new double[,] { { -7, 11 }, { 5, 5 } }, "(17.00, -1.00)\n(2.00, 74.00)\n");
        Test(new double[,] { { 3, -1, 2 }, { 4, 6, -5 }, { 7, 4, 6 } }, new double[,] { { 2, -2, 0 }, { 8, -8, 1 }, { 9, -5, 4 } }, "(16.00, -8.00, 7.00)\n(11.00, -31.00, -14.00)\n(100.00, -76.00, 28.00)\n");
        Test(new double[,] { { -1, 2 }, { 3, 4 } }, new double[,] { { 1, 2, 3 }, { 4, 5, 6 } }, "(7.00, 8.00, 9.00)\n(19.00, 26.00, 33.00)\n");
        Test(new double[,] { { 1, 2, 3 }, { -4, 5, 6 } }, new double[,] { { -6, 1 }, { -3, 9 }, { 2, 4 } }, "(-6.00, 31.00)\n(21.00, 65.00)\n");
        Test(new double[,] { { 1, 2, 3, -4 }, { 5, 6, 7, 8 } }, new double[,] { { 7, 11 }, { 3, 4 }, { -5, 5 }, { 1, 4 } }, "(-6.00, 18.00)\n(26.00, 146.00)\n");
        Test(new double[,] { { 1, 2, 3, -4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, -14, 15, 16 }, { 17, 18, 19, 20 } }, new double[,] { { 3 }, { 7 }, { -2 }, { 5 } }, "(-9.00)\n(83.00)\n(135.00)\n(-9.00)\n(239.00)\n");
        Test(new double[,] { { 1, 2 }, { -4, 6 } }, new double[,] { { 7, 11 }, { 3, 4 }, { -5, 5 } }, "(-1.00)\n");
        Test(new double[,] { { 1, 2 }, { -4, 6 } }, new double[,] { { 3, 7, 11 }, { 4, 3, 4 }, { 6, -5, 5 } }, "(-1.00)\n");
        Test(new double[,] { { 2 } }, new double[,] { { 4 } }, "(8.00)\n");
    }

    static void Test(double[,] matrix1, double[,] matrix2, string expected)
    {
        var result = MatrixMath.Multiply(matrix1, matrix2);
        PrintMatrix(result);
        Console.WriteLine("Expected:");
        Console.WriteLine(expected);
        Console.WriteLine();
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("(");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j].ToString("0.00"));
                if (j < matrix.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(")");
        }
    }
}
