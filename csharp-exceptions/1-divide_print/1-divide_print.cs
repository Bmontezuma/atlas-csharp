using System;

public class Int
{
    public static void divide(int a, int b)
    {
        try
        {
            int result = a / b;
            Console.WriteLine($"{a} / {b} = {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Division operation completed.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int a, b;

        a = 4;
        b = 3;
        Int.divide(a, b);
        Console.WriteLine();

        a = 9;
        b = 0;
        Int.divide(a, b);
    }
}
