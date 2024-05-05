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
        private int health;

        /// <summary>
        /// Represents the name of the zombie.
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with default health of 0 and default name of (No name).
        /// </summary>
        public Zombie()
        {
            health = 0;
            name = "(No name)";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with the specified health and default name of (No name).
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
                name = "(No name)";
            }
        }

        /// <summary>
        /// Gets or sets the name of the zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets the current health of the zombie.
        /// </summary>
        /// <returns>The current health value.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
