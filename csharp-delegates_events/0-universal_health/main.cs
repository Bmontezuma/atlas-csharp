using System;

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("Electric Mouse", 1000f);
        Player player2 = new Player("Electric Mouse");
        Player player3 = new Player(maxHp: 972f);
        Player player4 = new Player(null, 10f);
        Player player5 = new Player();
        Player player6 = new Player("Negative Test", -50f);

        player1.PrintHealth();
        player2.PrintHealth();
        player3.PrintHealth();
        player4.PrintHealth();
        player5.PrintHealth();
        player6.PrintHealth();
    }
}
