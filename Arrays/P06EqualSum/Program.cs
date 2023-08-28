using System;
using System.Linq;

namespace P06EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if an element exists in an array

            int[] inputArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //sum of all elements to the left is equal to all elements to the right
            int sumLeft = 0;
            int sumRight = 0;
            int foundIndex = 0;
            bool isFound = false;
            for (int i = 0; i < inputArr.Length; i++)
            {
                sumLeft = 0;
                sumRight = 0;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += inputArr[j];
                }

                for (int k = inputArr.Length - 1; k > i; k--)
                {
                    sumRight += inputArr[k];
                }

                if (sumLeft == sumRight)
                {
                    isFound = true;
                    foundIndex = i;
                    break;

                }

            }
            if (isFound)
            {


                Console.WriteLine(foundIndex);
            }


            else
            {
                Console.WriteLine("no");

            }

            //no elements to the left and right, the sum is 0

            //print the index of the element or no depending on the result

        }
    }
}
