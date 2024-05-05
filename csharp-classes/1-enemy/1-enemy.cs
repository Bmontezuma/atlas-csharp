using System;

namespace Enemies
{
    /// <summary>
    /// Represents a zombie enemy in the game.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Represents the health of the zombie.
        /// </summary>
        public int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with default health of 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
    }
}
