using System;

namespace P01ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var meters = int.Parse(Console.ReadLine());
            float kilometers = meters / 1000.0f;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}