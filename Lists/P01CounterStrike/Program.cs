using System;

namespace P01CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int winsCount = 0;
            int countWonBattle = 0;
            while (command != "End of battle" && energy >= 0)
            {
                int distance = int.Parse(command);
                if (energy >= distance)
                {
                    energy -= distance;


                    winsCount++;
                    countWonBattle++;
                    if (countWonBattle == 3)
                    {
                        energy += winsCount;
                        countWonBattle = 0;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winsCount} won battles and {energy} energy");
                    break;
                    
                }


                command = Console.ReadLine();

            }
            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {winsCount}. Energy left: {energy}");
                
            }
            
            }
        }
    }

