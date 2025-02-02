using System;

namespace P03Elevator
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberPeople = int.Parse(Console.ReadLine());

            int capacityOfElevator = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numberPeople / capacityOfElevator);

            Console.WriteLine(courses);
            
             
            
        }
    }
}
