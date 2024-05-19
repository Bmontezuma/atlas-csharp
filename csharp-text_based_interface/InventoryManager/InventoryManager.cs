using System;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManager
{
    /// <summary>
    /// Main program class for the Inventory Manager console application.
    /// </summary>
    class Program
    {
        private static JSONStorage storage = new JSONStorage();

        /// <summary>
        /// Entry point for the console application.
        /// </summary>
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Inventory Manager");
                Console.WriteLine("-------------------------");
                Console.WriteLine("<ClassNames> show all ClassNames of objects");
                Console.WriteLine("<All> show all objects");
                Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
                Console.WriteLine("<Create [ClassName]> a new object");
                Console.WriteLine("<Show [ClassName object_id]> an object");
                Console.WriteLine("<Update [ClassName object_id]> an object");
                Console.WriteLine("<Delete [ClassName object_id]> an object");
                Console.WriteLine("<Exit>");

                var input = Console.ReadLine().ToLower().Split(' ');

                if (input.Length == 0) continue;

                switch (input[0])
                {
                    case "classnames":
                        ShowClassNames();
                        break;
                    case "all":
                        if (input.Length == 1)
                        {
                            ShowAllObjects();
                        }
                        else if (input.Length == 2)
                        {
                            ShowAllObjects(input[1]);
                        }
                        break;
                    case "create":
                        if (input.Length == 2)
                        {
                            CreateObject(input[1]);
                        }
                        break;
                    case "show":
                        if (input.Length == 3)
                        {
                            ShowObject(input[1], input[2]);
                        }
                        break;
                    case "update":
                        if (input.Length == 3)
                        {
                            UpdateObject(input[1], input[2]);
                        }
                        break;
                    case "delete":
                        if (input.Length == 3)
                        {
                            DeleteObject(input[1], input[2]);
                        }
                        break;
                    case "exit":
                        storage.Save();
                        return;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }

        /// <summary>
        /// Displays all available class names.
        /// </summary>
        static void ShowClassNames()
        {
            Console.WriteLine("Item");
            Console.WriteLine("User");
            Console.WriteLine("Inventory");
        }

        /// <summary>
        /// Displays all stored objects.
        /// </summary>
        static void ShowAllObjects()
        {
            foreach (var obj in storage.All())
            {
                Console.WriteLine($"{obj.Key}: {obj.Value}");
            }
        }

        /// <summary>
        /// Displays all objects of a specified class name.
        /// </summary>
        /// <param name="className">Class name to filter objects by.</param>
        static void ShowAllObjects(string className)
        {
            foreach (var obj in storage.All())
            {
                if (obj.Key.StartsWith(className))
                {
                    Console.WriteLine($"{obj.Key}: {obj.Value}");
                }
            }
        }

        /// <summary>
        /// Creates a new object of the specified class name.
        /// </summary>
        /// <param name="className">Class name of the object to create.</param>
        static void CreateObject(string className)
        {
            switch (className.ToLower())
            {
                case "item":
                    Console.WriteLine("Enter name:");
                    var itemName = Console.ReadLine();
                    var item = new Item(itemName);
                    storage.New(item);
                    break;
                case "user":
                    Console.WriteLine("Enter name:");
                    var userName = Console.ReadLine();
                    var user = new User(userName);
                    storage.New(user);
                    break;
                case "inventory":
                    Console.WriteLine("Enter user id:");
                    var userId = Console.ReadLine();
                    Console.WriteLine("Enter item id:");
                    var itemId = Console.ReadLine();
                    var inventory = new Inventory(userId, itemId);
                    storage.New(inventory);
                    break;
                default:
                    Console.WriteLine($"{className} is not a valid object type");
                    break;
            }
        }

        /// <summary>
        /// Displays an object with the specified class name and ID.
        /// </summary>
        /// <param name="className">Class name of the object.</param>
        /// <param name="id">ID of the object.</param>
        static void ShowObject(string className, string id)
        {
            var key = $"{className}.{id}";
            if (storage.All().TryGetValue(key, out var obj))
            {
                Console.WriteLine(obj);
            }
            else
            {
                Console.WriteLine($"Object {id} could not be found");
            }
        }

        /// <summary>
        /// Updates an object with the specified class name and ID.
        /// </summary>
        /// <param name="className">Class name of the object.</param>
        /// <param name="id">ID of the object.</param>
        static void UpdateObject(string className, string id)
        {
            var key = $"{className}.{id}";
            if (storage.All().TryGetValue(key, out var obj))
            {
                // Implement object property updates here
            }
            else
            {
                Console.WriteLine($"Object {id} could not be found");
            }
        }

        /// <summary>
        /// Deletes an object with the specified class name and ID.
        /// </summary>
        /// <param name="className">Class name of the object.</param>
        /// <param name="id">ID of the object.</param>
        static void DeleteObject(string className, string id)
        {
            var key = $"{className}.{id}";
            if (storage.All().ContainsKey(key))
            {
                storage.All().Remove(key);
            }
            else
            {
                Console.WriteLine($"Object {id} could not be found");
            }
        }
    }
}
