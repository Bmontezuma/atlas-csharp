using System;

/// <summary>
/// Provides methods for vector mathematics.
/// </summary>
public static class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a scalar and returns the resulting vector.
    /// </summary>
    /// <param name="vector">The vector to be multiplied. Can be 2D or 3D.</param>
    /// <param name="scalar">The scalar to multiply the vector by.</param>
    /// <returns>A new vector that is the result of the multiplication, or a vector containing -1 if the input vector is invalid.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return new double[] { -1 };
        }

        double[] result = new double[vector.Length];

        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = Math.Round(vector[i] * scalar, 2);
        }

        return result;
    }
}

