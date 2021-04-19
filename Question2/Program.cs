using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.Write("Enter the name of your sickness *cancer**cold*: ");
            string sickness = Console.ReadLine();

            Console.Write("Enter your financial status *rich**poor*: ");
            string status = Console.ReadLine();

            string message;

            if (sickness == "cancer")
            {
                message = status == "rich"? "Surgery is recommended": "Making a public call is recommended";
            }else
            {
                message = status == "rich"? "We will take special care of you": "Try drinking tea";
            }
            Console.WriteLine(message);
        }
    }
}
