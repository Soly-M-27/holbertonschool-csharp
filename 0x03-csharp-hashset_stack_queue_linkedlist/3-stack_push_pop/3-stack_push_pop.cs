using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");
        
        if (aStack.Count > 0)
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }

        Console.WriteLine($"Stack contains \"{search}\": {(aStack.Contains(search) ? "True" : "False")}");

        if (aStack.Contains(search))
        {
            string result;
            do
            {
                result = aStack.Pop();
            } while (result != search);
        }

        aStack.Push(newItem);

        return (aStack);
    }
}