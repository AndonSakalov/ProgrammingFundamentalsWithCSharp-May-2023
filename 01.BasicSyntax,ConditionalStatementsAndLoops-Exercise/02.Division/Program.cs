namespace _02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int biggestDivisibleNumber = 0;
            bool isDivisible = false;
            if (number % 2 == 0)
            {
                biggestDivisibleNumber = 2;
                isDivisible = true;
            }
            if (number % 3 == 0)
            {
                biggestDivisibleNumber = 3;
                isDivisible = true;
            }
            if (number % 6 == 0)
            {
                biggestDivisibleNumber = 6;
                isDivisible = true;
            }
            if (number % 7 == 0)
            {
                biggestDivisibleNumber = 7;
                isDivisible = true;
            }
            if (number % 10 == 0)
            {
                biggestDivisibleNumber = 10;
                isDivisible = true;
            }
            if (!isDivisible)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {biggestDivisibleNumber}");
            }
        }
    }
}