// See https://aka.ms/new-console-template for more information
using System;
namespace Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] years = { 1923, 2022, 2000, 500 };

            int sum = 0;

            for (int i = 0; i < years.Length; i++)
            {
                if (years[i] % 4 == 0)
                {
                    Console.WriteLine("this is a leap year: " + years[i]);
                    sum += years[i];
                }
                else
                {
                    Console.WriteLine("this is not a leap year : " + years[i]);
                }
            }

            Console.WriteLine("sum of leap years are "+ sum);






        }
    }
}

