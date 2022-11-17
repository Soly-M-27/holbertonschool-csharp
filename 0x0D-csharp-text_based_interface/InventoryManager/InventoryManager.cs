using System;
using InventoryLibrary;

namespace InventoryManager
{
    class Application
    {
        public Dictionary<string, InventoryLibrary> myDict = new Dictionary<string, InventoryLibrary>
        {
            {"BaseClass", BaseClass},
            {"Inventory", Inventory},
            {"User", User},
            {"Item", Item}
        };
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
            storage.Load();

            user_input = Console.ReadLine();

            string[] words = user_input.Split(' ');

            Create(words[0]); 
            /*if (words[0] && !words[1])
            {

            }*/
        }

        public void Create(string arg)
        {
            if (arg.Length == 0)
            {
                Console.WriteLine("** class name missing **");
            }
            else if (arg)
            {
                foreach (var _class in myDict)
                {
                    if (arg == _class.key)
                    {
                        JSONStorage.New(arg);
                        Console.WriteLine("** Class has been created **");
                        Console.WriteLine(arg.id);
                    }   
                }
            }
        }

    }
}