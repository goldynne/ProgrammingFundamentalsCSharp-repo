using System;
using System.Collections.Generic;
using System.Linq;

namespace P01CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            List<string> strList = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<char> charList = new List<char>();
            foreach (var item in strList)
            {
                List<char> newCharList = item.ToList();
                foreach (var item1 in newCharList)
                {
                    charList.Add(item1);
                }
               
            }
            
                
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char ch in charList)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] += 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }
    }
}
