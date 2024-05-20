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
        Name = name;
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
}
