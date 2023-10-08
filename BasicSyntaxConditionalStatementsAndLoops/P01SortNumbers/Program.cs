using System;
using System.Collections.Generic;
using System.Linq;

namespace P01SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = new List<int>();



            for (int i = 1; i <= 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);

            }
            numbers.Sort();
            numbers.Reverse();
            Console.WriteLine(String.Join(Environment.NewLine, numbers));
        }
    }
}
