﻿using System;

namespace VectorMathLibrary
{
    /// <summary>
    /// Class for vector math operations.
    /// </summary>
    public class VectorMath
    {
        /// <summary>
        /// Calculates the magnitude of a given vector.
        /// </summary>
        /// <param name="vector">Array representing the vector.</param>
        /// <returns>The magnitude of the vector, rounded to the nearest hundredth. Returns -1 if the vector is not 2D or 3D.</returns>
        public static double Magnitude(double[] vector)
        {
            // Check if the vector is 2D or 3D
            if (vector.Length != 2 && vector.Length != 3)
            {
                return -1; // Return -1 if the vector is not 2D or 3D
            }

            // Calculate the magnitude
            double sumOfSquares = 0;
            foreach (var component in vector)
            {
                sumOfSquares += Math.Pow(component, 2);
            }

            return Math.Round(Math.Sqrt(sumOfSquares), 2); // Return the rounded magnitude
        }
    }
}
