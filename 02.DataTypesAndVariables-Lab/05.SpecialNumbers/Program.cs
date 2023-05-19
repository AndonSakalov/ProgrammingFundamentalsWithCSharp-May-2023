namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfNumbers; i++)
            {
                int number = i;
                bool isSpecial = false;
                int currentDigit = 0;
                int sum = 0;
                while (number > 0)
                {
                    currentDigit = number % 10;
                    sum += currentDigit;
                    number /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}