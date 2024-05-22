using System;

public enum Modifier
{
    Weak,
    Base,
    Strong
}

public delegate float CalculateModifier(float baseValue, Modifier modifier);

public static class ModifierExtensions
{
    public static float ApplyModifier(this Modifier modifier, float baseValue)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue / 2;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                throw new ArgumentOutOfRangeException(nameof(modifier), modifier, null);
        }
    }
}

public class Player
{
    // ... (previous code)

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        return modifier.ApplyModifier(baseValue);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");
        CalculateModifier mod = new CalculateModifier(player.ApplyModifier);

        player.PrintHealth();

        player.TakeDamage(mod(50f, Modifier.Weak));

        player.PrintHealth();

        player.HealDamage(mod(10f, Modifier.Strong));

        player.PrintHealth();
    }
}