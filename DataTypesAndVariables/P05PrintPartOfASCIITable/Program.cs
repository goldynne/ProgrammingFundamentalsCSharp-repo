using System;

namespace P05PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstCharacterIndex = int.Parse(Console.ReadLine());

            int lastCharacterIndex = int.Parse(Console.ReadLine());
            for (int i = firstCharacterIndex; i <= lastCharacterIndex; i++)
            {
                char newCh = (char)i;
                Console.Write($"{newCh} ");

                //for (char ch = 'A'; ch <= 'Z'; ch++)
                //{
                //    Console.Write($"{ch} ");
                //}
            }
        }
    }
}
