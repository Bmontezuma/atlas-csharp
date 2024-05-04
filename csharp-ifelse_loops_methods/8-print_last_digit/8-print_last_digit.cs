using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        // Take the absolute value to handle negative numbers
        number = Math.Abs(number);

        // Extract the last digit using modulo operator
        int lastDigit = number % 10;

        // Print the last digit
        Console.WriteLine(lastDigit);

        // Return the last digit
        return lastDigit;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int r;

        Number.PrintLastDigit(98);
        Number.PrintLastDigit(0);
        r = Number.PrintLastDigit(-1024);
        Console.WriteLine(r);
    }
}
