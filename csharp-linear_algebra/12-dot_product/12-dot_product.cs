using System;

namespace VectorMathLibrary
{
    public static class VectorMath
    {
        public static double DotProduct(double[] vector1, double[] vector2)
        {
            // Check if vectors are either both 2D or both 3D
            if ((vector1.Length != 2 && vector1.Length != 3) || vector1.Length != vector2.Length)
            {
                return -1;
            }

            // Calculate dot product
            double result = 0;
            for (int i = 0; i < vector1.Length; i++)
            {
                result += vector1[i] * vector2[i];
            }

            return result;
        }
    }
}
