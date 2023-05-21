using System;

namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long biggerNumberDigitsSum = 0;
                long [] numbersArray = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
                long number1 = numbersArray[0];
                long number2 = numbersArray[1];
                if (numbersArray[0] > numbersArray[1])
                {
                    while (number1 != 0)
                    {
                        biggerNumberDigitsSum += number1 % 10;
                        number1 /= 10;
                    }
                }

                else 
                {
                    while (number2 != 0)
                    {
                        biggerNumberDigitsSum += number2 % 10;
                        number2 /= 10;
                    }                   
                }

                Console.WriteLine(Math.Abs(biggerNumberDigitsSum));
            }
        }
    }
}