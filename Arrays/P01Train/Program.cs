using System;
using System.Linq;

namespace P01Train
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberWagons = int.Parse(Console.ReadLine());                      
            int sumPeople = 0;
            int[] numberPeople = new int[numberWagons];
            for (int i = 0; i < numberWagons; i++)
            {                
                numberPeople[i] = int.Parse(Console.ReadLine());                              
                
            }

            for (int j = 0; j < numberWagons; j++)
            {

                sumPeople = sumPeople + numberPeople[j];

            }
            Console.WriteLine(String.Join(" ", numberPeople));
            Console.WriteLine(sumPeople);
        }
    }
}
