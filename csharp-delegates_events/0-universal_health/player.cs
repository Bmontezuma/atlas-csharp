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
            this.maxHp = maxHp > 0 ? maxHp : 100f; // Ensure maxHp is always positive
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
