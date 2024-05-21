﻿using System;

/// <summary>
/// Represents a player entity with health properties.
/// </summary>
public class Player
{
    private string _name;
    private float _maxHp;
    private float _hp;

    /// <summary>
    /// Gets or sets the name of the player.
    /// </summary>
    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    /// <summary>
    /// Gets or sets the maximum health points of the player.
    /// </summary>
    public float MaxHp
    {
        get { return _maxHp; }
        private set { _maxHp = value > 0 ? value : 100f; }
    }

    /// <summary>
    /// Gets the current health points of the player.
    /// </summary>
    public float Hp
    {
        get { return _hp; }
        private set { _hp = value; }
    }

    /// <summary>
    /// Creates a new instance of the <see cref="Player"/> class with the specified name and maximum health points.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health points of the player.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        Name = name;
        MaxHp = maxHp;
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
