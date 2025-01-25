using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExamP02CoffeeLover
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> coffeesInStock = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();


            int numberCommands = int.Parse(Console.ReadLine());

            while (numberCommands>0)
            {


                List<string> command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                if (command[0]== "Include")
                {
                    coffeesInStock.Add(command[1]);
                }else if (command[0]== "Remove")
                {
                    if (coffeesInStock.Count >=int.Parse(command[2]))
                    {


                        if (command[1] == "first")
                        {
                            coffeesInStock.RemoveRange(0, int.Parse(command[2]));
                        }
                        else if (command[1] == "last")
                        {
                            coffeesInStock.RemoveRange(coffeesInStock.Count - int.Parse(command[2]), int.Parse(command[2]));      //евентуално може да трябва да е coffeesInStock.Count -1
                        }
                    }                    
                }
                else if (command[0]== "Prefer")
                {
                    if (int.Parse(command[1])>=0 && int.Parse(command[1])<coffeesInStock.Count && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < coffeesInStock.Count)
                    {
                        string middleCoffee = coffeesInStock[int.Parse(command[2])];
                        coffeesInStock[int.Parse(command[2])] = coffeesInStock[int.Parse(command[1])];
                        coffeesInStock[int.Parse(command[1])] = middleCoffee;
                    }
                }
                else if (command[0] == "Reverse")
                {
                    coffeesInStock.Reverse();
                }        

                numberCommands--;
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(String.Join(" ", coffeesInStock));
        }
    }
}
