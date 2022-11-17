using System;
using InventoryLibrary;

namespace InventoryLibrary
{
    /// <summary>
    /// Item Class
    /// </summary>
    public class Item : BaseClass
    {
        private string name { get; set; }
        public string description { get; set; }
        private float price
        { 
            get; 
            set
            {
                this.price = (float)Math.Round(value, 2);
            }
        }
        List<string> tags = new List<string>();

        /// <summary>
        /// Public Item Constructor
        /// </summary>
        /// <param name="name">name of item</param>
        public Item(string name)
        {
            this.name = name;
        }
    }
}