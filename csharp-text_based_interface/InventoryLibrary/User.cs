using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents a user in the system.
    /// </summary>
    public class User : BaseClass
    {
        /// <summary>
        /// Name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the User class with the specified name.
        /// </summary>
        /// <param name="name">Name of the user.</param>
        public User(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
