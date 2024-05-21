﻿using System;

/// <summary>
/// Class representing a player with health attributes.
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Gets the name of the player.
    /// </summary>
    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    /// <summary>
    /// Gets the maximum health points of the player.
    /// </summary>
    public float MaxHp
    {
        get { return maxHp; }
        private set 
        { 
            if (value <= 0f)
            {
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
                maxHp = 100f;
            }
            else
            {
                maxHp = value;
            }
        }
    }

    /// <summary>
    /// Gets or sets the current health points of the player.
    /// </summary>
    public float Hp
    {
        get { return hp; }
        private set { hp = value; }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class with a specified name and maximum health points.
    /// </summary>
    /// <param name="name">The name of the player. Default is "Player".</param>
    /// <param name="maxHp">The maximum health points of the player. Default is 100f.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        Name = name;
        MaxHp = maxHp;
        Hp = MaxHp;
    }

    /// <summary>
    /// Prints the player's health status.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{Name} has {Hp} / {MaxHp} health");
    }
}
