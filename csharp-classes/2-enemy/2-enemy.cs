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

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with the specified health.
        /// </summary>
        /// <param name="value">The initial health value.</param>
        /// <exception cref="ArgumentException">Thrown when the provided health value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0", nameof(value));
            }
            else
            {
                health = value;
            }
        }
    }
}
