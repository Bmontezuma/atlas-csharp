using System;

namespace MatrixMathLibrary
{
    class MainClass {
        public static void Main (string[] args) {
            double[,] matrix0 = {
                { 7, -3 },
                { 1, -6 }
            };
            
            double[,] inverseMatrix0 = MatrixMath.Inverse2D(matrix0);
            PrintMatrix(inverseMatrix0);

            double[,] matrix1 = {
                { 2, 0 },
                { -8, -6 }
            };
            
            double[,] inverseMatrix1 = MatrixMath.Inverse2D(matrix1);
            PrintMatrix(inverseMatrix1);

            double[,] matrix2 = {
                { 3, -3 },
                { 1, -1 }
            };
            
            double[,] inverseMatrix2 = MatrixMath.Inverse2D(matrix2);
            PrintMatrix(inverseMatrix2);

            double[,] matrix3 = {
                { 3, -3, 0 },
                { 1, -7, -1 },
                { 9, 3, -2 }
            };
            
            double[,] inverseMatrix3 = MatrixMath.Inverse2D(matrix3);
            PrintMatrix(inverseMatrix3);

            double[,] matrix4 = {
                { 4 },
                { 8 },
                { 2 },
                { -4 }
            };
            
            double[,] inverseMatrix4 = MatrixMath.Inverse2D(matrix4);
            PrintMatrix(inverseMatrix4);
        }

        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
