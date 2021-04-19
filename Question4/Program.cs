using System;

namespace Question4
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

            
            Console.WriteLine(Sum(arrOfNum));
        }

        static int Sum (int[] arrOfNum)
        {
            int sum = 0;
            for (int i = 0; i < arrOfNum.Length; i++)
            {
                sum += arrOfNum[i];
            }
            return sum;
        }
    }
}
