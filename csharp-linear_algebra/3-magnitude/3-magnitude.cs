﻿using System;

public class VectorMath
{
    /// <summary>
    /// Calculates the magnitude of a 2D or 3D vector and rounds it to the nearest hundredth.
    /// </summary>
    /// <param name="vector">The vector represented as an array of doubles.</param>
    /// <returns>
    /// The magnitude of the vector rounded to the nearest hundredth.
    /// Returns -1 if the vector is not 2D or 3D.
    /// </returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            double magnitude = Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1]);
            return Math.Round(magnitude, 2);
        }
        else if (vector.Length == 3)
        {
            double magnitude = Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]);
            return Math.Round(magnitude, 2);
        }
        else
        {
            return -1;
        }
    }
}
