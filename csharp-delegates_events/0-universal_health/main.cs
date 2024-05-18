using System;
using _0_universal_health;

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("Electric Mouse", 1000f);
        Player player2 = new Player("Electric Mouse");

        player1.PrintHealth();
        player2.PrintHealth();
    }
}
