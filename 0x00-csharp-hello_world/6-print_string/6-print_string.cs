﻿using System;

namespace repeat_string_3_times
{
        class Program
        {
                static void Main(string[] args)
                {
                        string str = "Holberton School";
                        string new_str = new StringBuilder(str.Length * 3).Insert(0, str, 3).ToString();                
                        Console.WriteLine(new_str);
                        Console.WriteLine(str.Substring(0,9));
                }
        }
}