using System;

namespace VectorMath
{
    public static class VectorMath
    {
        /// <summary>
        /// Calculates the magnitude of a given vector.
        /// </summary>
        /// <param name="vector">An array representing the vector components.</param>
        /// <returns>The magnitude of the vector rounded to the nearest hundredth, or -1 if the vector is not 2D or 3D.</returns>
        public static double Magnitude(double[] vector)
        {
            if (vector.Length == 2)
            {
                // 2D vector
                return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 2);
            }
            else if (vector.Length == 3)
            {
                // 3D vector
                return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 2);
            }
            else
            {
                // Invalid vector
                return -1;
            }
        }
    }
}

public class Class1
{

}
