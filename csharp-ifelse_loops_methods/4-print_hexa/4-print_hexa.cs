using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0, j = 0x10; i < 100; i++, j += 0x10)
        {
            Console.Write($"{i} = 0x{i:X2} ");
            if (i == j - 0x10)
            {
                Console.WriteLine();
                Console.Write($"{i + 1} = 0x{i + 1:X2} ");
            }
        }
    }
}
