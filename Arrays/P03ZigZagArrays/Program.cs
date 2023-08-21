using System;
using System.Linq;

namespace P03ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] zigArray = new int[n];
            int[] zagArray = new int[n];
            for (int i = 1; i <= n; i++)
            {

                int[] items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                
                


                if (i % 2 == 0)
                {
                    zigArray[i-1] = items[1];
                    zagArray[i-1] = items[0];

                }
                else
                {

                    
                    zigArray[i-1] = items[0];
                    zagArray[i-1] = items[1];
                }
            }


            Console.WriteLine(String.Join(" ", zigArray));
            Console.WriteLine(String.Join(" ", zagArray));
        }
    }
}

