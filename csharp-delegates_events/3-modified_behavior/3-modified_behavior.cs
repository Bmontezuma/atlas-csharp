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
/// Delegate to calculate modifier for a player's action.
/// </summary>
/// <param name="baseValue">The base value to modify.</param>
/// <param name="modifier">The modifier to apply.</param>
/// <returns>The modified value.</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Provides a method to apply a modifier to a base value.
/// </summary>
public static class ModifierHelper
{
    /// <summary>
    /// Applies a modifier to a base value.
    /// </summary>
    /// <param name="baseValue">The base value to modify.</param>
    /// <param name="modifier">The modifier to apply.</param>
    /// <returns>The modified value.</returns>
    public static float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                throw new ArgumentException("Invalid modifier");
        }
    }
}