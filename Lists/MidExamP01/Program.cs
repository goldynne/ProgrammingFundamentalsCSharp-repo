using System;

namespace MidExamP01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int biscuitsPerDayPerWorker = int.Parse(Console.ReadLine());

            int workersOwnFactory = int.Parse(Console.ReadLine());

            int biscuitsOtherFactory30Days = int.Parse(Console.ReadLine());

            double dailyresultThirdDay = Math.Floor(biscuitsPerDayPerWorker* workersOwnFactory*0.75);

            int biscuitsOwnFactory30Days = (int)((workersOwnFactory*biscuitsPerDayPerWorker  * 20) + dailyresultThirdDay * 10);
            
            
            Console.WriteLine($"You have produced {biscuitsOwnFactory30Days} biscuits for the past month.");

            double differenceInproductionBiscuits = 0;
            double percentDifference = 0;
            if (biscuitsOwnFactory30Days>biscuitsOtherFactory30Days)
            {
               
                differenceInproductionBiscuits = biscuitsOwnFactory30Days - biscuitsOtherFactory30Days;
                percentDifference = differenceInproductionBiscuits / biscuitsOtherFactory30Days * 100;

                Console.WriteLine($"You produce {percentDifference:F2} percent more biscuits.");

            }
            else if (biscuitsOtherFactory30Days>biscuitsOwnFactory30Days)
            {
                differenceInproductionBiscuits = biscuitsOtherFactory30Days - biscuitsOwnFactory30Days;
                percentDifference = Math.Round((differenceInproductionBiscuits/biscuitsOtherFactory30Days * 100),2);
                Console.WriteLine($"You produce {percentDifference:F2} percent less biscuits.");
            }

          


        }
    }
}
