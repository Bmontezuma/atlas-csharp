using System;

using Characters; // Add this using directive to access the Player class

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Floppy Fish");
        CalculateModifier mod = new CalculateModifier(player.ApplyModifier);

        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(25f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(51f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(75f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(99f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(100f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(0f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(33f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.HealDamage(mod(33f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.HealDamage(mod(45f, Modifier.Base));
        player.PrintHealth();
    }
}
