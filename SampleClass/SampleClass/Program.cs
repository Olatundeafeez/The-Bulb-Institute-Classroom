using System;

namespace SampleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int input3 = int.Parse(Console.ReadLine());

            int[] final = { input, input3 };

            int sum = SumInteger(final);
            Console.WriteLine(sum);

            //int vowelCount = CountVowels(input);

            //Console.WriteLine("The number of vowels in the string is: " + vowelCount);

            
        }


        static int CountVowels(string str)
        {
            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            foreach (char c in str)
            {
                if (Array.IndexOf(vowels, c) != -1)
                {
                    count++;
                }
            }

            return count;
        }


        static int SumInteger(int[] a)
        {
            int sum = 0;

            foreach (int i in a)
            {
                sum += i;
            }

            return sum;
        }
    }




}
