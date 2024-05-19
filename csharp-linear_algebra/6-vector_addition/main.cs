using System;

class Program
{
    static void Main()
    {
        // Sample vectors for testing
        double[] vector1 = { 1.5, 2.7, 3.1 }; // Example vector 1
        double[] vector2 = { -0.5, 1.3, 4.9 }; // Example vector 2

        // Call the Add method from VectorMath
        double[] result = VectorMath.Add(vector1, vector2);

        // Display the result
        Console.WriteLine("Resulting vector:");
        foreach (var element in result)
        {
            Console.WriteLine(element);
        }
    }
}
