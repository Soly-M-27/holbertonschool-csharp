using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        mod_num = number % 10;
        if (mod_num > 5)
        {
            Console.WriteLine("The last digit of {0:D} is {1:D} and is less than 6 and not 0", number, mod_num);
        }
        else if (mod_num == 0)
        {
            Console.WriteLine("The last digit of {0:D} is {1:D} and is 0", number, mod_num);
        }
        else
        {
            Console.WriteLine("The last digit of {0:D} is {1:D} and is greater than 5", number, mod_num);
        }
    }
}