using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Base class for all other classes in the InventoryLibrary project.
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// A unique identifier for the instance of the class.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The date and time when the instance of the class was created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The date and time when the instance of the class was last updated.
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseClass"/> class.
        /// </summary>
        public BaseClass()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.UtcNow;
            DateUpdated = DateTime.UtcNow;
        }
    }
}