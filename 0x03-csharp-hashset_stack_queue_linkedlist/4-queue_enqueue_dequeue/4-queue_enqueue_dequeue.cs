using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");
        
        if (aQueue.Count > 0)
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }

        Console.WriteLine($"Queue contains \"{search}\": {(aQueue.Contains(search) ? "True" : "False")}");

        if (aQueue.Contains(search))
        {
            string result;
            do
            {
                result = aQueue.Dequeue();
            } while (result != search);
        }

        aQueue.Enqueue(newItem);

        return (aQueue);
    }
}