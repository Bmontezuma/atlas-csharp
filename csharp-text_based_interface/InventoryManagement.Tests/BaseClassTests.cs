using System;
using Xunit;

namespace InventoryManagement.Tests
{
    /// <summary>
    /// Test class for BaseClass.
    /// </summary>
    public class BaseClassTests
    {
        /// <summary>
        /// Tests the constructor of BaseClass.
        /// </summary>
        [Fact]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange & Act
            var baseClass = new InventoryLibrary.BaseClass();

            // Assert
            Assert.False(string.IsNullOrEmpty(baseClass.Id));
            Assert.True(baseClass.DateCreated <= DateTime.Now);
            Assert.True(baseClass.DateUpdated <= DateTime.Now);
        }

        /// <summary>
        /// Tests the Id property of BaseClass.
        /// </summary>
        [Fact]
        public void Id_ShouldBeUnique()
        {
            // Arrange
            var baseClass1 = new InventoryLibrary.BaseClass();
            var baseClass2 = new InventoryLibrary.BaseClass();

            // Act & Assert
            Assert.NotEqual(baseClass1.Id, baseClass2.Id);
        }
    }
}
