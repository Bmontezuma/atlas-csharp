using System;

class Character
{
    public static bool IsLower(char c)
    {
        // Check if the ASCII value of the character falls within the range of lowercase letters
        return c >= 'a' && c <= 'z';
    }
}

class Program
{
    static void Main(string[] args)
    {
        char[] letters = { 'a', 'A', 'Q', 'h', '9', 'B', 'g' };
        int i;

        for (i = 0; i < letters.Length; i++)
        {
            if (Character.IsLower(letters[i]))
                Console.WriteLine("{0} is lowercase", letters[i]);
            else
                Console.WriteLine("{0} is uppercase", letters[i]);
        }
    }
}
