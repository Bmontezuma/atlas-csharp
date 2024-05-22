using System;

/// <summary>
/// Enum representing different modifiers that can be applied.
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak modifier that halves the base value.
    /// </summary>
    Weak,
    /// <summary>
    /// Base modifier that does not change the base value.
    /// </summary>
    Base,
    /// <summary>
    /// Strong modifier that multiplies the base value by 1.5.
    /// </summary>
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
/// Class representing a player with health points.
/// </summary>
public static class Player
{
    private static string name;
    private static float maxHp;
    private static float hp;

    /// <summary>
    /// Prints the player's health.
    /// </summary>
    public static void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Reduces the player's health by the specified damage amount.
    /// </summary>
    /// <param name="damage">The amount of damage to take.</param>
    public static void TakeDamage(float damage)
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
    public static void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        float newHp = hp + heal;
        ValidateHP(newHp);
    }

    private static void ValidateHP(float newHp)
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

    /// <summary>
    /// Applies the specified modifier to the base value.
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
