using System;
using System.Linq;

namespace P06EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i]%2==0)
                {
                    sumEven += items[i];
                }else
                {
                    sumOdd+=items[i];
                }
            }
            
                Console.WriteLine(sumEven-sumOdd);
            
        }
    }
}
