using System;
using InventoryLibrary;

namespace InventoryLibrary
{
    /// <summary>
    /// Public Class JSONStorage to serialize and deserialize .json file
    /// </summary>
    public class JSONStorage
    {
        private Dictionary<TClassName, Tid> objects = new Dictionary<TClassName, Tid>();

        /// <summary>
        /// Returns all objects from dictionary
        /// </summary>
        /// <returns>objects of dict</returns>
        public Dictionary All()
        {
            return (objects);
        }

        /// <summary>
        /// Adds new objects to the dictionary based on objects class name and id value
        /// </summary>
        /// <param name="obj">Contains both class name and id of object</param>
        /// <typeparam name="T">generic T declated in order for any paramete type to pass</typeparam>
        public void New<T>(T obj)
        {
            objects.Add($"{obj.GetType().name}.{obj.id}", obj);
        }

        /// <summary>
        /// Save method to serialize objects to JSONStorage file
        /// </summary>
        public void Save()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(objects, options);
            string fileName = "../storage/inventory_manager.json";
            File.WriteAllText(fileName, jsonString);
        }

        /// <summary>
        /// Load method to deserialize objects from JSONStorage file
        /// </summary>
        /// <param name="obj">objects from dict</param>
        /// <typeparam name="T">generic T declated in order for any paramete type to pass</typeparam>
        public void Load()
        {
            string fileName = "../storage/inventory_manager.json";
            string jsonString = File.ReadAllText(fileName);
            objects = JsonSerializer.Deserialize<Dictionary<($"{objects.key.GetType().name}"), ($"{objects.id}")>(jsonString);
        }
    }
}