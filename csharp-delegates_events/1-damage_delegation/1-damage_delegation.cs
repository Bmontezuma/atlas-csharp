// Player.cs
using System;

/// <summary>
/// Represents a player with health points.
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Delegate to calculate health changes.
    /// </summary>
    /// <param name="amount">The amount to change the health by.</param>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Gets the player's name.
    /// </summary>
    public string Name
    {
        get { return name; }
    }

    /// <summary>
    /// Gets the player's maximum health points.
    /// </summary>
    public float MaxHp
    {
        get { return maxHp; }
    }

    /// <summary>
    /// Gets the player's current health points.
    /// </summary>
    public float Hp
    {
        get { return hp; }
    }

    /// <summary>
    /// Initializes a new instance of the Player class.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health points of the player.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// Prints the player's health.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Reduces the player's health by the specified damage amount.
    /// </summary>
    /// <param name="damage">The amount of damage to take.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
        hp = Math.Max(hp - damage, 0);
    }

    /// <summary>
    /// Increases the player's health by the specified heal amount.
    /// </summary>
    /// <param name="heal">The amount of health to restore.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        hp = Math.Min(hp + heal, maxHp);
    }
}
