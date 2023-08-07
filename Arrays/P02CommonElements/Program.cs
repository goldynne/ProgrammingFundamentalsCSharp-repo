using System;
using System.Linq;

namespace P02CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] items1 = Console.ReadLine().Split().ToArray();


            string[] items2 = Console.ReadLine().Split().ToArray();

            string common = string.Empty;

            for (int i = 0; i < items2.Length; i++)
            {
                for (int j = 0; j < items1.Length; j++)
                {
                    if (items1[j] == items2[i])
                    {
                        common += $"{items2[i]} ";
                    }
                }
            }
            Console.Write(common);  
            }
        }
    }

