using System;
using InventoryLibrary;

namespace InventoryLibrary
{
    /// <summary>
    /// Class User
    /// </summary>
    public class User : BaseClass
    {
        private string name { get; set; }

        /// <summary>
        /// Public User Constructor
        /// </summary>
        /// <param name="name">name of user</param>
        public User(string name)
        {
            this.name = name;
        }
    }
}