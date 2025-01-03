using System;

namespace P02SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num >0)
            {
                int currentNum = num % 10;
                sum += currentNum;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
