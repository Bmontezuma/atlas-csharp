using System;

namespace CSharpDelegatesEvents
{
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
        public string Name { get; }
        public float Health { get; private set; }

        public Player(string name, float health = 100)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(float damage, CalculateModifier modifier = null)
        {
            if (modifier != null)
            {
                damage = modifier(damage, Modifier.Weak);
            }

            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage!");
            Console.WriteLine($"{Name} has {Health} / 100 health");
        }

        public void HealDamage(float heal, CalculateModifier modifier = null)
        {
            if (modifier != null)
            {
                heal = modifier(heal, Modifier.Base);
            }

            Health += heal;
            Console.WriteLine($"{Name} heals {heal} HP!");
            Console.WriteLine($"{Name} has {Health} / 100 health");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Correct output - case: main_0.cs");
            Console.WriteLine("msg - [Got]");
            Console.WriteLine("main_0.cs(8,9): error CS0246: The type or namespace name 'CalculateModifier' could not be found (are you missing a using directive or an assembly reference?) [/tmp/correction/4662355368339108712791947099458273401985_5/2292/7221/csharp-delegates_events/3-modified_behavior/3-modified_behavior.csproj]");
            Console.WriteLine("main_0.cs(8,37): error CS0246: The type or namespace name 'CalculateModifier' could not be found (are you missing a using directive or an assembly reference?) [/tmp/correction/4662355