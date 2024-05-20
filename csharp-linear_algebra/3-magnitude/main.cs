using System;

namespace VectorMathLibrary
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Test cases
            double[] vector1 = { 3, -7 };
            double[] vector2 = { -9, 1, -4 };
            double[] vector3 = { 0, 0 };
            double[] vector4 = { 1, 2, 3, 4 };
            double[] vector5 = { 6 };
            double[] vector6 = { };

            // Test the Magnitude method
            Console.WriteLine($"Magnitude of vector {string.Join(", ", vector1)}: {VectorMath.Magnitude(vector1)}");
            Console.WriteLine($"Magnitude of vector {string.Join(", ", vector2)}: {VectorMath.Magnitude(vector2)}");
            Console.WriteLine($"Magnitude of vector {string.Join(", ", vector3)}: {VectorMath.Magnitude(vector3)}");
            Console.WriteLine($"Magnitude of vector {string.Join(", ", vector4)}: {VectorMath.Magnitude(vector4)}");
            Console.WriteLine($"Magnitude of vector {string.Join(", ", vector5)}: {VectorMath.Magnitude(vector5)}");
            Console.WriteLine($"Magnitude of vector {string.Join(", ", vector6)}: {VectorMath.Magnitude(vector6)}");
        }
    }
}
