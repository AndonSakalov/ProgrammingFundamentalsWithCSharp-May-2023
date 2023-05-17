﻿namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sumOfEvenNumbers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!(numbers[i] % 2 == 1))
                {
                    sumOfEvenNumbers += numbers[i];
                }
            }
            Console.WriteLine(sumOfEvenNumbers);
        }
    }
}