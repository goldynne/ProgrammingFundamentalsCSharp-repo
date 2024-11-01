using System;

namespace P04SumОfChars
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberCharacters = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numberCharacters; i++)
            {
                char newCharacter = Console.ReadLine()[0];
                sum += (int)newCharacter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
