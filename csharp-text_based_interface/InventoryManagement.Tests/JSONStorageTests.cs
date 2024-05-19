using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    /// <summary>
    /// Test class for JSONStorage.
    /// </summary>
    public class JSONStorageTests
    {
        /// <summary>
        /// Tests that the storage file is correctly loaded.
        /// </summary>
        [Fact]
        public void Load_ShouldInitializeObjects()
        {
            // Arrange
            var storage = new JSONStorage();
            storage.New(new Item("Test Item"));
            storage.Save();

            // Act
            var newStorage = new JSONStorage();

            // Assert
            Assert.NotEmpty(newStorage.All());
        }

        /// <summary>
        /// Tests that objects are correctly serialized and saved to a JSON file.
        /// </summary>
        [Fact]
        public void Save_ShouldSerializeObjectsToFile()
        {
            // Arrange
            var storage = new JSONStorage();
            var item = new Item("Test Item");
            storage.New(item);
            var filePath = "storage/inventory_manager.json";

            // Act
            storage.Save();

            // Assert
            Assert.True(File.Exists(filePath));
            var json = File.ReadAllText(filePath);
            Assert.Contains(item.Id, json);
        }

        /// <summary>
        /// Tests that new objects can be added to the storage.
        /// </summary>
        [Fact]
        public void New_ShouldAddObjectToStorage()
        {
            // Arrange
            var storage = new JSONStorage();
            var item = new Item("Test Item");

            // Act
            storage.New(item);

            // Assert
            Assert.Contains($"Item.{item.Id}", storage.All().Keys);
        }

        /// <summary>
        /// Tests that all stored objects can be retrieved.
        /// </summary>
        [Fact]
        public void All_ShouldReturnAllStoredObjects()
        {
            // Arrange
            var storage = new JSONStorage();
            var item = new Item("Test Item");
            storage.New(item);

            // Act
            var allObjects = storage.All();

            // Assert
            Assert.Contains($"Item.{item.Id}", allObjects.Keys);
        }
    }
}
