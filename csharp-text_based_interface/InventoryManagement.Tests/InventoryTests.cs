using System;
using Xunit;

namespace InventoryManagement.Tests
{
    /// <summary>
    /// Test class for Inventory.
    /// </summary>
    public class InventoryTests
    {
        /// <summary>
        /// Tests the constructor of Inventory.
        /// </summary>
        [Fact]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            var userId = "user123";
            var itemId = "item123";
            var quantity = 5;

            // Act
            var inventory = new InventoryLibrary.Inventory(userId, itemId, quantity);

            // Assert
            Assert.Equal(userId, inventory.UserId);
            Assert.Equal(itemId, inventory.ItemId);
            Assert.Equal(quantity, inventory.Quantity);
        }

        /// <summary>
        /// Tests that quantity cannot be less than 0.
        /// </summary>
        [Fact]
        public void Constructor_ShouldThrowExceptionIfQuantityIsLessThanZero()
        {
            // Arrange
            var userId = "user123";
            var itemId = "item123";
            var quantity = -1;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new InventoryLibrary.Inventory(userId, itemId, quantity));
        }
    }
}
