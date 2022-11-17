using System;
using InventoryLibrary;

namespace InventoryLibrary
{
    /// <summary>
    /// Inventory Class inheriting from BaseClass
    /// </summary>
    public class Inventory : BaseClass
    {
        User user_id { get; set; }
        Item item_id { get; set; }
        int quantity;

        /// <summary>
        /// Inventory Constructor
        /// </summary>
        /// <param name="user_id">from User class</param>
        /// <param name="item_id">from Item class</param>
        /// <param name="quantity">must be 1 by default</param>
        public Inventory(User user_id, Item item_id, int quantity = 1)
        {
            if (quantity == 0)
            {
                throw new Exception("Quantity must be greater than 0");
            }

            this.user_id = user_id;
            this.item_id = item_id;
            this.quantity = quantity;
        }
    }
}