using System;
using InventoryLibrary;

namespace InventoryManager
{
    class Application
    {
        public void Main(string[] args){

            string user_input;

            InventoryLibrary.JSONStorage.Load();

            Console.WriteLine("Inventory Manager" +
                            "-------------------------" +
                            "<ClassNames> show all ClassNames of objects" +
                            "<All> show all objects" +
                            "<All [ClassName]> show all objects of a ClassName" +
                            "<Create [ClassName]> a new object" +
                            "<Show [ClassName object_id]> an object" +
                            "<Update [ClassName object_id]> an object" +
                            "<Delete [ClassName object_id]> an object" +
                            "<Exit>");

            user_input = Console.ReadLine();

            string[] words = user_input.Split(' ');
            
            if (words[0] && !words[1])
            {
                
            }
        }
    }
}


