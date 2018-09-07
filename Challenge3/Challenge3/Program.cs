using System;

namespace Challenge2
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int loopCount = 0; loopCount < 5; loopCount++)
            {
                for (int displayNumber = 1; displayNumber < 11; displayNumber++)
                {
                    Console.WriteLine(displayNumber);
                }
                for (int displayNumber = 10; displayNumber > 0; --displayNumber)
                {
                    Console.WriteLine(displayNumber);
                }

            }
        }
    }
}
