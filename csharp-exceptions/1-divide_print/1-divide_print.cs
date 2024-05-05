using System;

class Int
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
            Console.WriteLine($"{a} / {b} = {(b == 0 ? 0 : (a / b))}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Int.divide(12, 2);
        Int.divide(7, 0);
        Int.divide(12, -2);
        Int.divide(0, 2);
        Int.divide(10, 0);
        Int.divide(0, 0);
    }
}
