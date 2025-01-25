using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExamP03PhoneShop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> listPhones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            



            string command = Console.ReadLine();
            while (command != "End")
            {

                List<string> line = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                if (line[0] == "Add")
                {
                    if (!listPhones.Contains(line[2]))
                    {
                        listPhones.Add(line[2]);
                    }
                    

                }
                else if (line[0] == "Remove")
                {
                    if (listPhones.Contains(line[2]))
                    {
                        listPhones.Remove(line[2]);
                    }
                }
                else if (line[0] == "Bonus")
                {
                    List<string> newList = new List<string>();
                    newList = line[3].Split(':', StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (listPhones.Contains(newList[0]))
                    {
                        int index = listPhones.FindIndex(a => a == newList[0]);
                        listPhones.Insert(index +1,newList[1]);
                    }
                }
                else if (line[0] == "Last")
                {
                    if (listPhones.Contains(line[2]))
                    {
                        listPhones.Remove(line[2]);
                        listPhones.Add(line[2]);
                    }
                }
                command = Console.ReadLine();   
            }
            Console.WriteLine(String.Join(", ", listPhones));

        }
    }
}
