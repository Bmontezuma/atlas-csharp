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
        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Represents the possible modifiers for the player's action.
    /// </summary>
    public enum Modifier
    {
        Weak,
        Base,
        Strong
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
        float newHp = hp - damage;
        ValidateHP(newHp);
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
        float newHp = hp + heal;
        ValidateHP(newHp);
    }

    /// <summary>
    /// Validates and sets the player's health points.
    /// </summary>
    /// <param name="newHp">The new health points to set.</param>
    private void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }

        HPCheck?.Invoke(this, new CurrentHPArgs(hp));
    }

    private string status = " is ready to go!";

    /// <summary>
    /// Represents the status of the player based on current health.
    /// </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        float ratio = e.CurrentHp / maxHp;

        if (ratio == 1)
            status = " is in perfect health!";
        else if (ratio >= 0.5f && ratio < 1)
            status = " is doing well!";
        else if (ratio >= 0.25f && ratio < 0.5f)
            status = " isn't doing too great...";
        else if (ratio > 0 && ratio < 0.25f)
            status = " needs help!";
        else if (ratio == 0)
            status = " is knocked out!";

        Console.WriteLine($"{name}{status}");
    }

    /// <summary>
    /// Represents the event handler for checking current HP.
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;
}

/// <summary>
/// Represents the arguments for current HP.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Gets the current HP.
    /// </summary>
    public float CurrentHp { get; }

    /// <summary>
    /// Initializes a new instance of the CurrentHPArgs class.
    /// </summary>
    /// <param name="currentHp">The current HP.</param>
    public CurrentHPArgs(float currentHp)
    {
        CurrentHp = currentHp;
    }
}

/// <summary>
/// Delegate to calculate modifier for a player's action.
/// </summary>
/// <param name="baseValue">The base value to modify.</param>
/// <param name="modifier">The modifier to apply.</param>
/// <returns>The modified value.</returns>
public delegate float CalculateModifier(float baseValue, Player.Modifier modifier);
