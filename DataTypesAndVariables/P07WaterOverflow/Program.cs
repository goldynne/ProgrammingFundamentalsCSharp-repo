using System;

namespace P07WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {

            int lines = int.Parse(Console.ReadLine());
            
            int overallLitresInTank = 0;
            for (int i = 1; i <= lines; i++)
            {
                int litres = int.Parse(Console.ReadLine());


                if ((overallLitresInTank + litres) > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    overallLitresInTank += litres;
                }                
            }
            Console.WriteLine(overallLitresInTank);
        }
    }
}

