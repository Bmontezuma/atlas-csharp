using System;
using Xunit;

namespace InventoryManagement.Tests
{
    /// <summary>
    /// Test class for User.
    /// </summary>
    public class UserTests
    {
        /// <summary>
        /// Tests the constructor of User.
        /// </summary>
        [Fact]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            var name = "Test User";

            // Act
            var user = new InventoryLibrary.User(name);

            // Assert
            Assert.Equal(name, user.Name);
        }
    }
}
