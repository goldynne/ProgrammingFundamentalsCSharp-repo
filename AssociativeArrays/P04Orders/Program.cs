using System;
using System.Collections.Generic;
using System.Linq;

namespace P04Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, int>> products = new Dictionary<string, Dictionary<double, int>>();

            string input = Console.ReadLine();

            while (input!="buy")
            {
                string[] line = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = line[0];
                double price = int.Parse(line[1]);
                int quantity = int.Parse(line[2]);


                if (products.ContainsKey(name))
                {
                    products[name] = price, quantity;
                }


                input =Console.ReadLine();
            }
            


        }
    }
}
