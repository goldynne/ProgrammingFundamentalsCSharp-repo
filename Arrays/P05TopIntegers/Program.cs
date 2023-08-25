using System;
using System.Linq;

namespace P05TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int topIntegersIndex = 0;
            int[] topIntegers = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                bool isTopInteger = true;
                for (int j = i +1; j < arr.Length; j++)
                {
                    int nextNum = arr[j];
                    if (currentNum <= nextNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    topIntegers[topIntegersIndex] = currentNum;
                    topIntegersIndex++;
                }
            }

            for (int i = 0; i < topIntegersIndex; i++)
            {
                Console.Write($"{topIntegers[i]} ");
            }
            

            
            
        }
    }
}
