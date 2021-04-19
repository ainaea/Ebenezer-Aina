using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int[] arrOfNum = new int[50];

            for (int i = 0; i < arrOfNum.Length; i++)
            {
                arrOfNum[i] = i+1;
            }

            int sum = 0;
            for (int i = 0; i < arrOfNum.Length; i++)
            {
                sum += arrOfNum[i];
            }

            Console.WriteLine(sum);
        }
    }
}
