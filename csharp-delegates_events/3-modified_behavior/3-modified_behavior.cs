using System;

/// <summary>
/// Represents a player with health points.
/// </summary>
public class Player
{
    private float hp;
    private float maxHp;
    private string name;
    private string status;

    /// <summary>
    /// Event handler for checking current HP.
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// Initializes a new instance of the Player class.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health points of the player.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }

        status = $"{this.name} is ready to go!";
        hp = this.maxHp = maxHp;
        HPCheck += CheckStatus;
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
            damage = 0f;
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Increases the player's health by the specified heal amount.
    /// </summary>
    /// <param name="heal">The amount of health to restore.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0f;
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validates the new HP value and updates the player's HP.
    /// </summary>
    /// <param name="newHp">The new HP value.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0f;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;

        HPCheck?.Invoke(this, new CurrentHPArgs(hp));
    }

    /// <summary>
    /// Applies a damage/heal modifier to a value.
    /// </summary>
    /// <param name="baseValue">The value to be modified.</param>
    /// <param name="modifier">The modifier to apply.</param>
    /// <returns>The modified value.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Base:
                return baseValue;
            default:
                return baseValue * 1.5f;
        }
    }

    /// <summary>
    /// Updates the player's status based on current HP.
    /// </summary>
    /// <param name="sender">The event sender.</param>
    /// <param name="e">The event arguments.</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            status = $"{name} is in perfect health!";
        else if (e.currentHp < maxHp && e.currentHp >= maxHp / 2)
            status = $"{name} is doing well!";
        else if (e.currentHp < maxHp / 2 && e.currentHp >= maxHp / 4)
            status = $"{name} isn't doing too great...";
        else if (e.currentHp > 0f && e.currentHp < maxHp / 2)
            status = $"{name} needs help!";
        else
            status = $"{name} is knocked out!";

        Console.WriteLine(status);
    }
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
/// Represents the arguments for current HP.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// The current HP.
    /// </summary>
    public readonly float currentHp;

    /// <summary>
    /// Initializes a new instance of the CurrentHPArgs class.
    /// </summary>
    /// <param name="newHp">The current HP.</param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
