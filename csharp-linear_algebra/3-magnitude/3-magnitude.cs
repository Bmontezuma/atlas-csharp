﻿using System;

/// <summary>
/// Provides methods for vector mathematics.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the magnitude (length) of a vector.
    /// </summary>
    /// <param name="vector">The input vector, which can be 2D or 3D.</param>
    /// <returns>The magnitude of the vector, rounded to the nearest hundredth.
    /// If the input vector is not 2D or 3D, returns -1.</returns>
    public static double Magnitude(double[] vector)
    {
        // Check if the vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }

        double sum = 0;

        // Calculate the sum of the squares of the vector components
        for (int x = 0; x < vector.Length; x++)
        {
            sum += vector[x] * vector[x];
        }

        // Calculate and round the length of the vector
        return Math.Round(Math.Sqrt(sum), 2);
    }
}