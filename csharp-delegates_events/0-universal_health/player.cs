using System;

/// <summary>
/// Represents a player with health attributes.
/// </summary>
public class Player
{
    /// <summary>
    /// Gets the name of the player.
    /// </summary>
    public string Name { get; }

    private float _maxHp;
    /// <summary>
    /// Gets the maximum health points of the player.
    /// </summary>
    public float MaxHp
    {
        get => _maxHp;
        private set
        {
            if (value <= 0)
            {
                _maxHp = 100f;
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            }
            else
            {
                _maxHp = value;
            }
        }
    }

    private float _hp;
    /// <summary>
    /// Gets the current health points of the player.
    /// </summary>
    public float Hp
    {
        get => _hp;
        private set
        {
            // Ensure hp doesn't exceed maxHp
            _hp = Math.Min(value, MaxHp);
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class with specified name and maximum health points.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health points of the player.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        Name = name;
        MaxHp = maxHp;
        Hp = maxHp; // Set current health to maximum health
    }

    /// <summary>
    /// Prints the health of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{Name} has {Hp} / {MaxHp} health");
    }
}
