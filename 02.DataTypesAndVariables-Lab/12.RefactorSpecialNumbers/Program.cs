namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        private static int sum;

        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());            
            bool isSpecial = false;
            for (int i = 1; i <= numbersCount; i++)
            {
                int currentNumber = i;
                int sum = 0;
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }
    }
}