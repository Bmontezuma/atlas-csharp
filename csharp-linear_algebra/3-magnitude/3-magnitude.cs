﻿using System;

namespace VectorMathLibrary
{
    /// <summary>
    /// Class for vector math operations.
    /// </summary>
    public class VectorMath
    {
        private double[] vector;

        /// <summary>
        /// Constructor for VectorMath class.
        /// </summary>
        /// <param name="vector">Array representing the vector.</param>
        public VectorMath(double[] vector)
        {
            this.vector = vector;
        }

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the component to get or set.</param>
        /// <returns>The value of the component at the specified index.</returns>
        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= vector.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return vector[index];
            }
            set
            {
                if (index < 0 || index >= vector.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                vector[index] = value;
            }
        }

        /// <summary>
        /// Calculates the magnitude of the vector.
        /// </summary>
        /// <returns>The magnitude of the vector, rounded to the nearest hundredth. Returns -1 if the vector is not 2D or 3D.</returns>
        public double Magnitude()
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
