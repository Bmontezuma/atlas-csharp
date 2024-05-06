using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 99; i++)
        {
            Console.Write($"{i} = 0x{i:X2} ");
            if ((i + 1) % 10 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}
