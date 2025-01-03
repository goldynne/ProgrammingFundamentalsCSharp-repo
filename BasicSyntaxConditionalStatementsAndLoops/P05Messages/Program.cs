using System;

namespace P05Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberLines = int.Parse(Console.ReadLine());
            string finalResult = "";
            for (int i = 1; i <= numberLines; i++)
            {

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 2:
                        finalResult +="a";
                        break;
                    case 22:
                    
                        finalResult += "b";
                        break;
                    case 222:
                        finalResult += "c";
                        break;
                    case 3:
                        finalResult += "d";
                        break;
                    case 33:
                        finalResult += "e";
                        break;
                    case 333:
                        finalResult += "f";
                        break;
                    case 4:
                        finalResult += "g";
                        break;
                    case 44:
                        finalResult += "h";
                        break;
                    case 444:
                        finalResult += "i";
                        break;
                    case 5:
                        finalResult += "j";
                        break;
                    case 55:
                        finalResult += "k";
                        break;
                    case 555:
                        finalResult += "l";
                        break;
                    case 6:
                        finalResult += "m";
                        break;
                    case 66:
                        finalResult += "n";
                        break;
                    case 666:
                        finalResult += "o";
                        break;
                    case 7:
                        finalResult += "p";
                        break;
                    case 77:
                        finalResult += "q";
                        break;
                    case 777:
                        finalResult += "r";
                        break;
                    case 7777:
                        finalResult += "s";
                        break;
                    case 8:
                        finalResult += "t";
                        break;
                    case 88:
                        finalResult += "u";
                        break;
                    case 888:
                        finalResult += "v";
                        break;
                    case 9:
                        finalResult += "w";
                        break;
                    case 99:
                        finalResult += "x";
                        break;
                    case 999:
                        finalResult += "y";
                        break;
                    case 9999:
                        finalResult += "z";
                        break;
                    case 0:
                        finalResult += " ";
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(finalResult);
        }
    }
}
