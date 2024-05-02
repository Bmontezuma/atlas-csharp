using System;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "Holberton";
        string str2 = "School";
        string welcomeMessage = string.Concat("Welcome to ", str1, " ", str2, "!");
        Console.WriteLine(welcomeMessage);
    }
}
