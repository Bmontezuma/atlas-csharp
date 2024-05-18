using System;

namespace InventoryLibrary
{
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

        public BaseClass()
        {
            Id = Guid.NewGuid().ToString(); // Generate a new GUID for Id
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
        }
    }
}
