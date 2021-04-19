using System;

namespace Question5
{
    class Program
    {
        enum Months {January=1, February, March, April, May, June, July, August, September, October, November, December}
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            while (true)
            {
                Console.Write("Enter a number between 1-12 to play and any other number to quit: ");
                int num = int.Parse( Console.ReadLine());

                if (num < 1 || num > 12)
                {
                    Console.Write("Good bye");
                    break;
                }
            
                Console.WriteLine((Months) num);
            }
        }
    }
}
