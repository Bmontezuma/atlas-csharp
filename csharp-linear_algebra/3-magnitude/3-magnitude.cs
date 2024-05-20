﻿using System;

/// <summary>
/// Provides methods for vector mathematics.
/// </summary>
public class CustomVectorMath
{
    /// <summary>
    /// Calculates the magnitude of a vector.
    /// </summary>
    /// <param name="vector">The input vector, which can be of any dimension.</param>
    /// <returns>The magnitude of the vector, rounded to two decimal places.
    /// If the input vector is invalid, returns -1.</returns>
    public static double CalculateMagnitude(double[] vector)
    {
        // Check if the vector is valid (non-null and has at least one component)
        if (vector == null || vector.Length == 0)
        {
            return -1;
        }

        double sumOfSquares = 0;

        // Calculate the sum of the squares of the vector components
        foreach (double component in vector)
        {
            sumOfSquares += component * component;
        }

        // Calculate and round the magnitude of the vector
        double magnitude = Math.Sqrt(sumOfSquares);
        return Math.Round(magnitude, 2);
    }
}
