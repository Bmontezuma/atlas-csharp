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
            ValidateTestCase(vector1, vector2, 1);

            vector1 = new double[] { -3, 4, 13 };
            vector2 = new double[] { 0, 17, -5 };
            ValidateTestCase(vector1, vector2, 3);

            vector1 = new double[] { -1, 2 };
            vector2 = new double[] { 0, 0, -5 };
            ValidateTestCase(vector1, vector2, -1);

            vector1 = new double[] { 6, 1, -2 };
            vector2 = new double[] { 0, 0 };
            ValidateTestCase(vector1, vector2, -1);

            vector1 = new double[] { 6, 1, -2, 7 };
            vector2 = new double[] { 0, 0 };
            ValidateTestCase(vector1, vector2, -1);

            vector1 = new double[] { -2, 7, 9 };
            vector2 = new double[] { 10, 0, -1, 2 };
            ValidateTestCase(vector1, vector2, -1);
        }

        // Helper method to validate a test case
        private static void ValidateTestCase(double[] vector1, double[] vector2, double expected)
        {
            double result = VectorMath.DotProduct(vector1, vector2);
            Console.WriteLine($"Dot product of vectors {ArrayToString(vector1)} and {ArrayToString(vector2)}: {result}");
            Console.WriteLine($"Expected: {expected}");

            if (result == expected)
                Console.WriteLine("Test Passed!");
            else
                Console.WriteLine("Test Failed!");
            
            Console.WriteLine();
        }

        // Helper method to convert array to string for printing
        private static string ArrayToString(double[] array)
        {
            return "{" + string.Join(", ", array) + "}";
        }
    }
}
