using System;
using InventoryLibrary;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        User user_id { get; set; }
        Item item_id { get; set; }
        int quantity;

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