using System;

namespace VectorMathLibrary
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            // Test cases
            double[] vector1 = { 7, 11 };
            double[] vector2 = { -3, 2 };
            Console.WriteLine($"Dot product of vectors {ArrayToString(vector1)} and {ArrayToString(vector2)}: {VectorMath.DotProduct(vector1, vector2)}");

            // Add more test cases as needed
        }

        // Helper method to convert array to string for printing
        private static string ArrayToString(double[] array)
        {
            return "{" + string.Join(", ", array) + "}";
        }
    }
}
