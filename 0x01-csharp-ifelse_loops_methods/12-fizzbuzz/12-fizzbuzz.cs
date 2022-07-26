using System;

class FizzBuzz
{
    public static void Main(string[] args)
    {
        for (int x = 1; x <= 100; x++)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.Write("FizzBuzz ");
            }
            else if (x % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            else if (x % 5 == 0 && x != 100)
            {
                Console.Write("Buzz ");
            }
            else
            {
                Console.Write("{0}", x);
            }
        }
        Console.WriteLine("Buzz");
    }
}