using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 11);

        Console.Write(number + " is ");

        if (number > 0)
        {
            Console.WriteLine("positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("negative");
        }
        else
        {
            Console.WriteLine("zero");
        }
    }
}
