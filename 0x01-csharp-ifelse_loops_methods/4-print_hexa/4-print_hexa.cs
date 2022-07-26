/** Write a program that prints all numbers from 0 to 98 
 * in decimal and in hexadecimal (as in the following example)
 *
 *  -You can only use Console.Write once
 *  -You can only use one loop in your code
 **/

using System;

class Program
{
    static void Main(string[] args)
    {
        for (int x = 0; x <= 98; x++)
        {
            Console.Write("{0:D} = 0x{0:X}\n", x);
        }
    }   
}
