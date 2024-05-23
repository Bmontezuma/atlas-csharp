using System;

namespace VectorMathLibrary
{
    class MainClass {
        public static void Main (string[] args) {
            double[] vector1 = { 1, 2, 3 };
            double[] vector2 = { 4, 5, 6 };

            double[] crossProduct = VectorMath.CrossProduct(vector1, vector2);

            Console.WriteLine("Cross Product:");
            Console.WriteLine(string.Join(", ", crossProduct));
        }
    }
}
