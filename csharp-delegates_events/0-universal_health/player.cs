using System;

namespace _0_universal_health
{
    /// <summary>
    /// Represents a player with health attributes.
    /// </summary>
    public class Player
    {
        private string name;
        private float maxHp;
        private float hp;

        /// <summary>
        /// Initializes a new instance of the Player class.
        /// </summary>
        /// <param name="name">Name of the player.</param>
        /// <param name="maxHp">Maximum health of the player.</param>
        public Player(string name = "Player", float maxHp = 100f)
        {
            this.name = name;
            if (maxHp > 0)
            {
                this.maxHp = maxHp;
            }
            else
            {
                this.maxHp = 100f;
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            }
            this.hp = this.maxHp;
        }

        /// <summary>
        /// Prints the player's current health status.
        /// </summary>
        public void PrintHealth()
        {
            Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
        }
    }
}