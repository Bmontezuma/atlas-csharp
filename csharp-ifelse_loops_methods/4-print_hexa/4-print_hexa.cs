using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i < 99)
        {
            Console.Write($"{i} = 0x{i:X2} ");
            if ((i + 1) % 10 == 0)
            {
                Console.WriteLine();
            }
            i++;
        }
    }
}
