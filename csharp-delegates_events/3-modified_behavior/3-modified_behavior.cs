using System;

public enum Modifier
{
    Weak,
    Base,
    Strong
}

public delegate float CalculateModifier(float baseValue, Modifier modifier);

public class Player
{
    private float health;
    public string name;

    public Player(string name = "Plant Dinosaur", float health = 100f)
    {
        if (health <= 0f)
        {
            Console.WriteLine("Health must be greater than 0. Setting default health to 100.");
            this.health = 100f;
        }
        else
        {
            this.health = health;
        }
        this.name = name;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {health} / 100 health");
    }

    public void TakeDamage(float damage)
    {
        if (damage <= 0f)
        {
            Console.WriteLine($"{name} takes 0 damage!");
        }
        else if (damage >= health)
        {
            Console.WriteLine($"{name} takes {health} damage!");
            health = 0f;
        }
        else
        {
            Console.WriteLine($"{name} takes {damage} damage!");
            health -= damage;
        }
    }

    public void HealDamage(float heal)
    {
        if (heal <= 0f)
        {
            Console.WriteLine($"{name} heals 0 HP!");
        }
        else
        {
            Console.WriteLine($"{name} heals {heal} HP!");
            health += heal;
            if (health > 100f)
            {
                health = 100f;
            }
        }
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue / 2f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                Console.WriteLine("Invalid modifier.");
                return baseValue;
        }
    }
}
