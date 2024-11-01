using System;

namespace P08BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {

            int beerKegsNum = int.Parse(Console.ReadLine());
            decimal biggestKegVolume = 0;
            string biggestKeg = string.Empty;
            for (int i = 1; i <= beerKegsNum; i++)
            {
                string model = Console.ReadLine();

                double radius = double.Parse(Console.ReadLine());

                int height = int.Parse(Console.ReadLine());

                decimal volume = (decimal)(Math.PI * Math.Pow(radius, 2) * height);
                if (volume>biggestKegVolume)
                {
                    biggestKegVolume = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
