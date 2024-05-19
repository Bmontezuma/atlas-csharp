using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents an inventory record linking a user and an item.
    /// </summary>
    public class Inventory : BaseClass
    {
        /// <summary>
        /// User ID associated with the inventory record.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Item ID associated with the inventory record.
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// Quantity of the item in the inventory, default value is 1 and cannot be less than 0.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Initializes a new instance of the Inventory class with the specified user ID, item ID, and quantity.
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="itemId">Item ID.</param>
        /// <param name="quantity">Quantity of the item.</param>
        public Inventory(string userId, string itemId, int quantity = 1)
        {
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity cannot be less than 0");
            }

            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
            ItemId = itemId ?? throw new ArgumentNullException(nameof(itemId));
            Quantity = quantity;
        }
    }
}
