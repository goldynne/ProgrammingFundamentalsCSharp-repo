using System;
using System.Numerics;

namespace P11Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberSnowballs = int.Parse(Console.ReadLine());
            BigInteger highestSnowballValue = BigInteger.Zero;
            //int parsedNum;
            //bool isInteger = int.TryParse(Console.ReadLine(), out parsedNum);
            //if (isInteger)
            //{
            //    Console.WriteLine($"The text was the integer:{parsedNum}");
            //}
            //else
            //{
            //    Console.WriteLine("The text was not integer");
            //}
            int highestSnowballSnow = 0;
            int highestSnowballTime = 0;
            int highestSnowballQuality = 0;
            
            while (numberSnowballs > 0)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                int snowballDivide = snowballSnow / snowballTime;


                BigInteger snowballValue = BigInteger.Pow(snowballDivide, snowballQuality);

                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballValue = snowballValue;
                    highestSnowballSnow = snowballSnow;
                    highestSnowballTime = snowballTime;
                    highestSnowballQuality = snowballQuality;
                }


                numberSnowballs--;
            }
 


            Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {highestSnowballValue} ({highestSnowballQuality})");

        }



    }
}

