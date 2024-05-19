using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Base class for all other classes, providing common properties.
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Date and time when the object was created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Date and time when the object was last updated.
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Initializes a new instance of the BaseClass, setting Id, DateCreated, and DateUpdated.
        /// </summary>
        public BaseClass()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
        }
    }
}
