using System;

namespace MyMath
{
    public static class Matrix
    {
        /// <summary>
        /// Divides all elements of a matrix by a specified number.
        /// </summary>
        /// <param name="matrix">The matrix to divide.</param>
        /// <param name="num">The number to divide each element by.</param>
        /// <returns>A new matrix containing the divided elements.</returns>
        /// <remarks>
        /// If num is 0, prints "Num cannot be 0" and returns null.
        /// If matrix is null, returns null.
        /// </remarks>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] / num;
                }
            }

            return result;
        }
    }
}
