using System;
using System.Linq;

namespace P01SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {




            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int[] input = { firstNum, secondNum, thirdNum };
            Console.WriteLine(SmallestNumber(input));
        }

        static int SmallestNumber(int[] input)
        {
            int smallestNumber = int.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {


                if (input[i] < smallestNumber)
                {
                    smallestNumber = input[i];
                }
            }
            return smallestNumber;
        }
    }
}
