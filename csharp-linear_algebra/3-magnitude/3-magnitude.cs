﻿using System;

namespace Magnitude
{
    /// <summary>
    /// A static class containing methods for vector mathematics.
    /// </summary>
    public static class VectorMath
    {
        /// <summary>
        /// Calculates the magnitude of a given vector.
        /// </summary>
        /// <param name="vector">The vector to calculate the magnitude of.</param>
        /// <returns>The magnitude of the vector, rounded to the nearest hundredth. If the vector is not a 2D or 3D vector, returns -1.</returns>
        /// <remarks>
        /// The vector can be 2D or 3D. If the vector is not a 2D or 3D vector, -1 is returned.
        /// </remarks>
        public static double Magnitude(double[] vector)
        {
            if (vector == null || (vector.Length != 2 && vector.Length != 3))
            {
                return -1;
            }

            double sum = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sum += vector[i] * vector[i];
            }

            return Math.Round(Math.Sqrt(sum), 2);
        }
    }
}