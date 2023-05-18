using System.Linq.Expressions;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = Math.Abs(input);
            int evenDigitSum = GetEvenAndOddSum(number,0);
            int oddDigitSum = GetEvenAndOddSum(number,1);
            Console.WriteLine(evenDigitSum * oddDigitSum);

        }
        static int GetEvenAndOddSum(int number, int evenOrOddCheck)
        {
            int currentDigit = 0;
            int sum = 0;
            while (number > 0)
            {
                currentDigit = number % 10;
                if (currentDigit % 2 == evenOrOddCheck)
                {
                    sum += currentDigit;
                }
                number /= 10;
            }
            return sum;
        }

    }
}