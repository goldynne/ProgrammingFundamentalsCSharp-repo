using System;
using System.Collections.Generic;
using System.Linq;

namespace P03LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string line = Console.ReadLine();

            Dictionary<string, int> legendaryItem = new Dictionary<string, int>()
            {
                { "shards", 0},
                {"motes", 0 },
                {"fragments", 0 }
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            int sumShards = 0;
            int sumFragments = 0;
            int sumMotes = 0;
            bool itemObtained = false;
            while (!itemObtained)
            {
                List<string> input = line.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < input.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        if (input[i] == "shards")
                        {
                            sumShards += int.Parse(input[i - 1]);
                            if (sumShards >= 250)
                            {
                                Console.WriteLine($"Shadowmourne obtained!");
                                legendaryItem["shards"] = sumShards - 250;
                                itemObtained = true;
                                break;
                            }
                            else if (legendaryItem.ContainsKey("shards"))
                            {
                                legendaryItem["shards"] = sumShards;
                            }
                            else
                            {

                                legendaryItem.Add("shards", int.Parse(input[i - 1]));
                            }
                        }
                        else if (input[i] == "fragments")
                        {
                            sumFragments += int.Parse(input[i - 1]);
                            if (sumFragments >= 250)
                            {
                                Console.WriteLine($"Valanyr obtained!");
                                legendaryItem["fragments"] = sumFragments - 250;
                                itemObtained = true;
                                break;
                            }

                            else if (legendaryItem.ContainsKey("fragments"))
                            {
                                legendaryItem["fragments"] = sumFragments;
                            }
                            else
                            {

                                legendaryItem.Add("fragments", int.Parse(input[i - 1]));
                            }
                        }
                        else if (input[i] == "motes")
                        {
                            sumMotes += int.Parse(input[i - 1]);
                            if (sumMotes >= 250)
                            {
                                Console.WriteLine($"Dragonwrath obtained!");
                                legendaryItem["motes"] = sumMotes - 250;
                                itemObtained = true;
                                break;

                            }


                            else if (legendaryItem.ContainsKey("motes"))
                            {
                                legendaryItem["motes"] = sumMotes;
                            }
                            else
                            {

                                legendaryItem.Add("motes", int.Parse(input[i - 1]));
                            }

                        }
                        else
                        {
                            if (junk.ContainsKey(input[i]))
                            {

                                junk[input[i]] += int.Parse(input[i - 1]);
                            }
                            else
                            {
                                junk.Add(input[i], int.Parse(input[i - 1]));
                            }
                        }



                    }
                }
                if (itemObtained)
                {
                    break;
                }
                line = Console.ReadLine();
            }
            foreach (var item in legendaryItem)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");

            }
        }
    }
}
