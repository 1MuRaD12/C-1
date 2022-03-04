using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n = 128, i , sum = 0;


            while (n > 0)
            {
                i = n % 10;
                sum = sum + i;
                n = n / 10;
                {
                    Console.WriteLine("sum of digits is {0}", sum);
                }
            }
        }
    }
}
