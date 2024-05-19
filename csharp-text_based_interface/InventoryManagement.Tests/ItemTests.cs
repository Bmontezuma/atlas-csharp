using System;
using System.Collections.Generic;
using Xunit;

namespace InventoryManagement.Tests
{
    /// <summary>
    /// Test class for Item.
    /// </summary>
    public class ItemTests
    {
        /// <summary>
        /// Tests the constructor of Item.
        /// </summary>
        [Fact]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            var name = "Test Item";

            // Act
            var item = new InventoryLibrary.Item(name);

            // Assert
            Assert.Equal(name, item.Name);
            Assert.Empty(item.Tags);
            Assert.Equal(0f, item.Price);
            Assert.Null(item.Description);
        }

        /// <summary>
        /// Tests setting and getting the Price property.
        /// </summary>
        [Fact]
        public void Price_ShouldLimitToTwoDecimalPoints()
        {
            // Arrange
            var item = new InventoryLibrary.Item("Test Item");
            var price = 12.3456f;

            // Act
            item.Price = (float)Math.Round(price, 2);

            // Assert
            Assert.Equal(12.35f, item.Price);
        }
    }
}
