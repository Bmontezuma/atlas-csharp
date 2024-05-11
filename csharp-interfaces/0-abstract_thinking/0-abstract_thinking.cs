using System;

namespace Borderlands3.Entities
{
    /// <summary>
    /// An abstract class representing a base entity in Borderlands 3.
    /// </summary>
    public abstract class Base
    {
        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Returns a string representation of the entity.
        /// </summary>
        /// <returns>A string in the format '<see cref="name"/> is a <see cref="T:Base"/>'.</returns>
        public override string ToString()
        {
            return $"{name} is a {GetType().Name}";
        }
    }

    /// <summary>
    /// A class representing Claptrap in Borderlands 3.
    /// </summary>
    public class Claptrap : Base
    {
        // Empty class
    }
}
