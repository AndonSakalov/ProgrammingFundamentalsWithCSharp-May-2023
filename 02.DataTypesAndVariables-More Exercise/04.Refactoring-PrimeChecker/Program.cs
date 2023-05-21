namespace _04.Refactoring_PrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            for (int i = 2; i <= countOfNumbers; i++)
            {
                bool isPrime = true;
                for (int cepitel = 2; cepitel < i; cepitel++)
                {
                    if (i % cepitel == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
            }
        }
    }
}