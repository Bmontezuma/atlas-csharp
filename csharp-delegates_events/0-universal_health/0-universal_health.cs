﻿using System;

/// <summary>
/// Represents a player entity with health properties.
/// </summary>
public class Player
{
    public string Name { get; }
    public float MaxHp { get; }
    public float Hp { get; private set; }

    /// <summary>
    /// Creates a new instance of the <see cref="Player"/> class with the specified name and maximum health points.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health points of the player.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        Name = name;
        MaxHp = Math.Max(maxHp, 0f); // Ensure maxHp is non-negative
        Hp = MaxHp;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
    }

    /// <summary>
    /// Prints the health status of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{Name} has {Hp} / {MaxHp} health");
    }
}
