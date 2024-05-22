using System;

namespace Characters
{
    public enum Modifier
    {
        Base,
        Strong,
        Weak
    }

    public class CurrentHPArgs : EventArgs
    {
        public float currentHp { get; }

        public CurrentHPArgs(float newHp)
        {
            currentHp = newHp;
        }
    }

    public delegate float CalculateModifier(float baseValue, Modifier mod);

    public class Player
    {
        public string Name { get; private set; }
        public float MaxHp { get; private set; }
        private string status = "<name> is ready to go!";

        public event EventHandler<CurrentHPArgs> HPCheck;

        public Player(string name)
        {
            Name = name;
            MaxHp = 100;
            HPCheck += CheckStatus;
        }

        private void CheckStatus(object sender, CurrentHPArgs e)
        {
            if (e.currentHp == MaxHp)
                Console.WriteLine($"{Name} is in perfect health!");
            else if (e.currentHp >= MaxHp / 2 && e.currentHp < MaxHp)
                Console.WriteLine($"{Name} is doing well!");
            else if (e.currentHp >= MaxHp / 4 && e.currentHp < MaxHp / 2)
                Console.WriteLine($"{Name} isn't doing too great...");
            else if (e.currentHp > 0 && e.currentHp < MaxHp / 4)
                Console.WriteLine($"{Name} needs help!");
            else if (e.currentHp == 0)
                Console.WriteLine($"{Name} is knocked out!");
        }

        public float ApplyModifier(float baseValue, Modifier mod)
        {
            switch (mod)
            {
                case Modifier.Strong:
                    return baseValue * 1.5f;
                case Modifier.Weak:
                    return baseValue * 0.5f;
                default:
                    return baseValue;
            }
        }

        public void TakeDamage(float damage)
        {
            MaxHp -= damage;
            HPCheck?.Invoke(this, new CurrentHPArgs(MaxHp));
        }

        public void HealDamage(float heal)
        {
            MaxHp += heal;
            HPCheck?.Invoke(this, new CurrentHPArgs(MaxHp));
        }

        public void PrintHealth()
        {
            Console.WriteLine($"{Name} has {MaxHp} / 100 health");
        }
    }
}
