using System;

public class MatrixOperations
{
    /// <summary>
    /// Calculates the inverse of a 2x2 matrix.
    /// </summary>
    /// <param name="matrix">A 2D double array representing the matrix.</param>
    /// <returns>The inverse of the matrix if invertible, otherwise [-1].</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        // Check if the input is a 2x2 matrix
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        // Extract elements for convenience
        double a = matrix[0, 0];
        double b = matrix[0, 1];
        double c = matrix[1, 0];
        double d = matrix[1, 1];

        // Calculate the determinant
        double determinant = a * d - b * c;

        // Check if the matrix is invertible
        if (determinant == 0)
        {
            return new double[,] { { -1 } };
        }

        // Calculate the inverse
        double[,] inverse = new double[2, 2];
        inverse[0, 0] = d / determinant;
        inverse[0, 1] = -b / determinant;
        inverse[1, 0] = -c / determinant;
        inverse[1, 1] = a / determinant;

        return inverse;
    }

    public static void Main()
    {
        // Example usage
        double[,] matrix = { { 1, 2 }, { 3, 4 } };
        double[,] result = Inverse2D(matrix);

        // Output the result
        if (result.Length == 1 && result[0, 0] == -1)
        {
            Console.WriteLine("Matrix is not invertible or not 2x2.");
        }
        else
        {
            Console.WriteLine("Inverse matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
