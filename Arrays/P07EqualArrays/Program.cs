using System;
using System.Linq;

namespace P07EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] items2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumItems = 0;
            

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != items2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    sumItems+=items[i];
                    if (i == items.Length-1)
                    {
                        Console.WriteLine($"Arrays are identical. Sum: {sumItems}");
                    }
                }

            }
        }
    }
}
