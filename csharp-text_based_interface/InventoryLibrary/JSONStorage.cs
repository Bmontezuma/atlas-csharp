using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    /// <summary>
    /// Manages storage and retrieval of objects in JSON format.
    /// </summary>
    public class JSONStorage
    {
        /// <summary>
        /// Dictionary holding all objects, with keys as <ClassName>.<id> and values as the objects.
        /// </summary>
        public Dictionary<string, BaseClass> Objects { get; private set; }

        private readonly string filePath = "storage/inventory_manager.json";

        /// <summary>
        /// Initializes a new instance of the JSONStorage class and loads existing data from the JSON file.
        /// </summary>
        public JSONStorage()
        {
            Load();
        }

        /// <summary>
        /// Returns the dictionary of all stored objects.
        /// </summary>
        /// <returns>Dictionary of all objects.</returns>
        public Dictionary<string, BaseClass> All()
        {
            return Objects;
        }

        /// <summary>
        /// Adds a new object to the storage.
        /// </summary>
        /// <param name="obj">Object to be added.</param>
        public void New(BaseClass obj)
        {
            var key = $"{obj.GetType().Name}.{obj.Id}";
            Objects[key] = obj;
        }

        /// <summary>
        /// Serializes all objects to JSON and saves them to the JSON file.
        /// </summary>
        public void Save()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(Objects, options);
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, json);
        }

        /// <summary>
        /// Loads objects from the JSON file into the storage.
        /// </summary>
        public void Load()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                Objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(json);
            }
            else
            {
                Objects = new Dictionary<string, BaseClass>();
            }
        }
    }
}
