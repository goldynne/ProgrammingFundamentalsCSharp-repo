using System;

namespace P02PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {

            var pounds = double.Parse(Console.ReadLine());
            double usd = pounds * 1.31;
            Console.WriteLine($"{usd:F3}");
        }
    }
}
