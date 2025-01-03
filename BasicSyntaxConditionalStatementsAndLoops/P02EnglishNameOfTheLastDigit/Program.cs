using System;

namespace P02EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Spelling(number));
        }

        static string Spelling(int number)
        {
            int newNumber = number % 10;
            string finalNumber = string.Empty;
            if (newNumber == 1)
            {
                finalNumber = "one";
            }
            else if (newNumber == 2)
            {
                finalNumber = "two";
            }
            else if (newNumber == 3)
            {
                finalNumber = "three";
            }
            else if (newNumber == 4)
            {
                finalNumber = "four";
            }
            else if (newNumber == 5)
            {
                finalNumber = "five";
            }
            else if (newNumber == 6)
            {
                finalNumber = "six";
            }
            else if (newNumber == 7)
            {
                finalNumber = "seven";
            }
            else if (newNumber == 8)
            {
                finalNumber = "eight";
            }
            else if (newNumber == 9)
            {
                finalNumber = "nine";
            }
            else if (newNumber == 0)
            {
                finalNumber = "zero";
            }


            return finalNumber;

        }
    }
}
