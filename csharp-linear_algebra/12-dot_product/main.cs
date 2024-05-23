using System;

namespace _18_matrix_matrix_mul
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new double[,] { { 1, 2 }, { 4, 5 }, { 7, 8 } };
            var b = new double[,] {{2,3},{4,5}};

            Console.WriteLine("Rows {0}, Columns {1}", a.GetLength(0), a.GetLength(1));

            var matrix = MatrixMath.Multiply(a, b);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("Row: ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"|{matrix[i, j]}|");
                }
                Console.WriteLine();
            }
        }
    }
}
