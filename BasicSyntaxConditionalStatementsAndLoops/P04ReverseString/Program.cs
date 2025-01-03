using System;
using System.Linq;

namespace P04ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            char[] array = Console.ReadLine().ToCharArray();
            Console.WriteLine(String.Join("", array.Reverse()));
        }
    }
}
