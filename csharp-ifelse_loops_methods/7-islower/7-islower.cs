using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Character.IsLower('a')); // Output: True
        Console.WriteLine(Character.IsLower('A')); // Output: False
        Console.WriteLine(Character.IsLower('1')); // Output: False
    }
}
