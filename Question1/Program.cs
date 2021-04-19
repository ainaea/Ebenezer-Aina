using System;
using System.Linq;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string [] userNames = new string []{"adeCrown", "olaWealth", "strengthOrMight", "icon345", "hard_to_get"};
            string [] passwords = new string []{"omooba", "olakitan", "OKUNRINMETA", "eyanLAYCON", "FAVSlayer"};

            Console.Write("Enter your username: ");
            string inputUserName = Console.ReadLine();

            Console.Write("Enter your password: ");
            string inputPassword = Console.ReadLine();

            if (userNames.Contains(inputUserName))
            {
                int index=0;
                for (int i = 0; i < userNames.Length; i++)
                {
                    if (userNames[i] == inputUserName )
                    {
                        index = i;
                        break;
                    }
                }

                if (passwords[index] == inputPassword)
                {
                    Console.WriteLine("Login successfull");
                }else
                {
                    Console.WriteLine("Incorrect password");
                }


                // userNames;
            }else
            {
                Console.WriteLine($"No match for username {inputUserName} found");
            }

        }
    }
}
