using System;

class Character
{
    public static bool IsLower(char c)
    {
        return c >= 'a' && c <= 'z';
    }
}

class Program
{
    static void Main(string[] args)
    {
        char[] letters = { 'a', 'A', 'Q', 'h', '9', 'B', 'g'};
        
        foreach (char letter in letters)
        {
            if (Character.IsLower(letter))
                Console.WriteLine("{0} is lowercase", letter);
            else
                Console.WriteLine("{0} is uppercase", letter);
        }
    }
}
