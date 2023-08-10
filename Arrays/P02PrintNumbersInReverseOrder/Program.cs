using System;

namespace P02PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] arrayInteger = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayInteger[i] = int.Parse(Console.ReadLine());
                
            }
            for (int j = arrayInteger.Length-1; j >=0; j--)
            {
                Console.Write($"{arrayInteger[j]} ");
                
            }
            
        }
    }
}
