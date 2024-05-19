using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents an item in the inventory.
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>
        /// Name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Price of the item, limited to 2 decimal points.
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// List of tags associated with the item.
        /// </summary>
        public List<string> Tags { get; set; }

        /// <summary>
        /// Initializes a new instance of the Item class with the specified name.
        /// </summary>
        /// <param name="name">Name of the item.</param>
        public Item(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Tags = new List<string>();
        }
    }
}
