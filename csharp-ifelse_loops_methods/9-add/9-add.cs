using System;

class Number
{
    public static int Add(int a, int b)
    {
        // Add the two integers
        int result = a + b;

        // Return the result
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("{0}", Number.Add(1, 2));
        Console.WriteLine("{0}", Number.Add(98, 0));
        Console.WriteLine("{0}", Number.Add(100, -2));
    }
}
