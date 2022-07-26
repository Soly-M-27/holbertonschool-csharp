using System;
class Program
{
	static void Main(string[] args)
	{
		int number = 972;
        foreach (string line in args)
            Console.WriteLine(number.ToString() + line);
	}
}