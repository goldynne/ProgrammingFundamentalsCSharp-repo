using System;
using System.Collections.Generic;

namespace P02AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            
            Dictionary<string, int> dict = new Dictionary<string, int>();
            while (input!="stop")
            {
                
                int quantity = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(input))
                {
                    dict[input] += quantity;
                }
                else
                {
                    dict.Add(input, quantity);
                    input = Console.ReadLine();
                }
                
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
