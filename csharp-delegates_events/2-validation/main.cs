using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Fire Fox");

        player.PrintHealth();

        player.TakeDamage(75f);

        player.HealDamage(74.9f);
    }
}
