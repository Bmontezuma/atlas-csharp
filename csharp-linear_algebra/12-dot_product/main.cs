using System;
using VectorMathLibrary;

class MainClass {
    public static void Main (string[] args) {
        // Test case
        double[] vector1 = { 7, 11 };
        double[] vector2 = { -3, 2 };

        double dotProduct = VectorMath.DotProduct(vector1, vector2);

        Console.WriteLine(dotProduct); // Output: 1
    }
}
