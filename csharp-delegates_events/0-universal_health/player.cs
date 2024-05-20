using System;

/// <summary>
/// Represents a player with health attributes.
/// </summary>
public class Player
{
    /// <summary>
    /// Gets the name of the player.
    /// </summary>
    public string PlayerName { get; }

    private float _maximumHealth;
    /// <summary>
    /// Gets the maximum health points of the player.
    /// </summary>
    public float MaximumHealth
    {
        get => _maximumHealth;
        private set
        {
            if (value <= 0)
            {
                _maximumHealth = 100f;
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            }
            else
            {
                _maximumHealth = value;
            }
        }
    }

    private float _currentHealth;
    /// <summary>
    /// Gets the current health points of the player.
    /// </summary>
    public float CurrentHealth
    {
        get => _currentHealth;
        private set
        {
            // Ensure current health doesn't exceed maximum health
            _currentHealth = Math.Min(value, MaximumHealth);
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class with specified name and maximum health points.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHealth">The maximum health points of the player.</param>
    public Player(string name = "Player", float maxHealth = 100f)
    {
        PlayerName = name;
        MaximumHealth = maxHealth;
        CurrentHealth = maxHealth; // Set current health to maximum health
    }

    /// <summary>
    /// Prints the health of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{PlayerName} has {CurrentHealth} / {MaximumHealth} health");
    }
}
