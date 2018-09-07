using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password");
            var password = Console.ReadLine();

            if (password == "secret")
            {
                Console.WriteLine("You have been authenticated.");
            }
            else
            {
                Console.WriteLine("Incorrect password.");
            }
        }
    }
}
