using System;

namespace P06TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            char end = (char)(97 + n);
            for (char i = 'a'; i < end; i++)
            {
                for (char j = 'a'; j < end; j++)
                {
                    for (char k = 'a'; k < end; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
