using System;

namespace P03GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double currentBalance = double.Parse(Console.ReadLine());
            double totalSpent = 0;

            string input = Console.ReadLine();

            while (input != "Game Time")
            {

                double price = 0;
                string name = "";
                if (input == "OutFall 4")
                {
                    name = "OutFall 4";
                    price = 39.99;

                }
                else if (input == "CS: OG")
                {
                    name = "CS: OG";
                    price = 15.99;
                }
                else if (input == "Zplinter Zell")
                {
                    name = "Zplinter Zell";
                    price = 19.99;
                }
                else if (input == "Honored 2")
                {
                    name = "Honored 2";
                    price = 59.99;
                }
                else if (input == "RoverWatch")
                {
                    name = "RoverWatch";
                    price = 29.99;
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    name = "RoverWatch Origins Edition";
                    price = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    input = Console.ReadLine();
                    continue;
                }

                if (currentBalance - price < 0)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    totalSpent += price;
                    Console.WriteLine($"Bought {name}");
                    if (currentBalance - price == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                input = Console.ReadLine();

            }
            if (input == "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${(currentBalance - totalSpent):F2}");
            }
        }
    }
}
