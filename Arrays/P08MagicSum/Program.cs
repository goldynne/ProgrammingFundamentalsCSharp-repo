using System;
using System.Linq;

namespace P08MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sequence = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = i + 1; j <= sequence.Length - 1; j++)
                {
                    if (sequence[i] + sequence[j] == number)
                    {
                        Console.WriteLine($"{sequence[i]} {sequence[j]}");
                    }
                }

            }

        }
    }
}
