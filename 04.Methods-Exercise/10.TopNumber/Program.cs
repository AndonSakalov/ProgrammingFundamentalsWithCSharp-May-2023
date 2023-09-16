namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopIntegersInRange(n);
        }

        static void PrintTopIntegersInRange(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                int sumOfDigits = 0;
                int oddDigitCount = 0;
                int number = i;
                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    if ((number % 10) % 2 != 0)
                    {
                        oddDigitCount++;
                    }
                    number /= 10;
                }
                if (sumOfDigits % 8 == 0 && oddDigitCount > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}