﻿using System;
using System.Linq;

/// <summary>
/// Provides methods for performing vector mathematics
/// </summary>
public static class VectorMathUtility
{
    /// <summary>
    /// Calculates the magnitude of a 2D or 3D vector
    /// </summary>
    /// <param name="vector">A 2D or 3D vector represented as an array of doubles</param>
    /// <returns>The magnitude of the vector, rounded to two decimal places</returns>
    public static double CalculateMagnitude(double[] vector)
    {
        if (vector.Length is not (2 or 3))
            return -1;

        double squaredSum = vector.Select(num => num * num).Sum();

        return Math.Round(Math.Sqrt(squaredSum), 2);
    }
}