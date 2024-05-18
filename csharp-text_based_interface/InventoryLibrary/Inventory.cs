using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        public string UserId { get; set; }
        public string ItemId { get; set; }
        public int Quantity { get; set; } = 1;

        public Inventory(string userId, string itemId)
        {
            UserId = userId;
            ItemId = itemId;
        }
    }
}