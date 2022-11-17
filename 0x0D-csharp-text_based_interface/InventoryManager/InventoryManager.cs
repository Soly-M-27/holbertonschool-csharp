using System;

namespace InventoryManagement
{
    class Application
    {
        public Dictionary<string, object> myDict = new Dictionary<string, object>
        {
            {"BaseClass", BaseClass},
            {"Inventory", Inventory},
            {"User", User},
            {"Item", Item}
        };
        public static void Main(string[] args){

            string user_input;

            JSONStorage.Load();

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
            else
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