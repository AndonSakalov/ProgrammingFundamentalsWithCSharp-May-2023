using System.Globalization;

namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenNumbersSum = 0;
            int oddNumbersSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNumbersSum += numbers[i];
                }
                if (numbers[i] % 2 != 1)
                {
                    evenNumbersSum += numbers[i];
                }
            }
            Console.WriteLine(evenNumbersSum - oddNumbersSum);
        }
    }
}