using System;

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("Water Turtle");
        Player player2 = new Player("Fire Lizard");

        player1.TakeDamage(21.3f);
        player1.HealDamage(76.16f);

        player2.TakeDamage(0.5f);
        player2.HealDamage(0.5f);

        player2.TakeDamage(763.7f);
        player2.HealDamage(559.3f);

        player2.TakeDamage(0f);
        player2.HealDamage(0f);

        player2.TakeDamage(-37.2f);
        player2.HealDamage(-6972.7f);
    }
}
