using System;

/// <summary>
/// Represents a player with health points.
/// </summary>
public class Player
{
    /// <summary>
    /// Gets the player's name.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Gets the player's maximum health points.
    /// </summary>
    public float MaxHp { get; private set; }

    /// <summary>
    /// Gets the player's current health points.
    /// </summary>
    public float Hp { get; private set; }

    /// <summary>
    /// Delegate for calculating health changes.
    /// </summary>
    /// <param name="amount">The amount to change health by.</param>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health points of the player.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        Name = name ?? "Player";
        MaxHp = maxHp;
        Hp = maxHp;
    }

    /// <summary>
    /// Prints the player's current health status.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{Name} has {Hp} / {MaxHp} health");
    }

    /// <summary>
    /// Applies damage to the player.
    /// </summary>
    /// <param name="damage">The amount of damage to apply.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        Console.WriteLine($"{Name} takes {damage} damage!");
        Hp = Math.Max(0, Hp - damage);
    }

    /// <summary>
    /// Heals the player.
    /// </summary>
    /// <param name="heal">The amount of healing to apply.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        Console.WriteLine($"{Name} heals {heal} HP!");
        Hp = Math.Min(MaxHp, Hp + heal);
    }
}
