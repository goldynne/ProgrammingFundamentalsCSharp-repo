using System;

namespace Centuries
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = 20;

            ushort years = 2000;

            uint days = 730484;

            ulong hours = 17531616;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours.", centuries, years, days, hours);
        }
    }
}
