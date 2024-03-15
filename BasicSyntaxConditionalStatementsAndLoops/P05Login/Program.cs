using System;

namespace P05Login
{
    class Program
    {
        static void Main(string[] args)
        {

            string username = Console.ReadLine();

            string passwordInput = Console.ReadLine();
            string password = "";
            int length = username.Length - 1;
            int numberTries = 1;
            while (length >= 0)
            {
                password += username[length];
                length--;
            }
            while (numberTries <= 4)
            {
                if (passwordInput != password)
                {
                    if (numberTries < 4)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"User {username} blocked!");
                    }
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                passwordInput = Console.ReadLine();
                numberTries += 1;
            }
        }
    }
}


