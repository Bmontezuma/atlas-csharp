﻿using System;

/// <summary>
/// Class containing vector math operations.
/// </summary>
public static class VectorMath
{
    /// <summary>
    /// Calculates the magnitude (length) of a 2D or 3D vector.
    /// </summary>
    /// <param name="vector">The vector represented as an array of doubles.</param>
    /// <returns>The magnitude of the vector rounded to the nearest hundredth, or -1 if the vector is not 2D or 3D.</returns>
    public static double Magnitude(double[] vector)
    {
        // Check if the vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1; // Return -1 if vector is not 2D or 3D
        }

        // Calculate magnitude based on dimensionality
        double sumOfSquares = 0;
        foreach (var component in vector)
        {
            sumOfSquares += component * component;
        }
        double magnitude = Math.Sqrt(sumOfSquares);

        // Round to the nearest hundredth
        magnitude = Math.Round(magnitude, 2);

        return magnitude;
    }
}