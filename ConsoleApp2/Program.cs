using System;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string st = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            string st1 = Console.ReadLine();
            var count = Regex.Matches(st, st1).Count;
            Console.WriteLine("Word found "+count+" times in the string");
        }
    }
}