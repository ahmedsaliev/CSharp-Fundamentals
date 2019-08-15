﻿using System;
using System.Text.RegularExpressions;

namespace _06.Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(text, pattern, replace);
                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }
        }
    }
}