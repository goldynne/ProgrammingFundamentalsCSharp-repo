using System;

namespace P03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberPeople = int.Parse(Console.ReadLine());

            string typeOfGroup = Console.ReadLine();

            string dayOfWeek = Console.ReadLine();

            double priceVacation = 0;
            if (dayOfWeek=="Friday")
            {
                if (typeOfGroup == "Students")
                {
                    priceVacation = numberPeople * 8.45;
                }
                else if (typeOfGroup == "Business")
                {
                    priceVacation = numberPeople * 10.90;
                }
                else if (typeOfGroup=="Regular")
                {
                    priceVacation = numberPeople * 15;
                }
            }
            if (dayOfWeek == "Saturday")
            {

                switch (typeOfGroup)
                {
                    case "Students" : priceVacation = numberPeople * 9.80; break;
                    case "Business" : priceVacation = numberPeople * 15.60; break;
                    case "Regular" : priceVacation = numberPeople * 20; break;
                    
                }
            }
            if (dayOfWeek == "Sunday")
            {

                switch (typeOfGroup)
                {
                    case "Students" : priceVacation = numberPeople * 10.46; break;
                    case "Business" : priceVacation = numberPeople * 16; break;
                    case "Regular" : priceVacation = numberPeople * 22.50; break;
            }

            }
            if (typeOfGroup == "Students")
            {
                if (numberPeople>=30)
                {
                    priceVacation *= 0.85;
                }
            }
            if (typeOfGroup == "Business")
            {
                if (numberPeople>=100)
                {

                    double priceFor10 = 0;
                    if (dayOfWeek =="Friday")
                    {
                        priceFor10 = 10 * 10.90;
                        priceVacation -= priceFor10;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        priceFor10 = 10 * 15.6;
                        priceVacation -= priceFor10;
                    }
                    else if (dayOfWeek=="Sunday")
                    {
                        priceFor10 = 10 * 16;
                        priceVacation -= priceFor10;
                    }
                    
                }
            }
            if (typeOfGroup == "Regular")
            {
                if (numberPeople>=10 && numberPeople<=20)
                {
                    priceVacation *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {priceVacation:F2}");
        }
    }
}
