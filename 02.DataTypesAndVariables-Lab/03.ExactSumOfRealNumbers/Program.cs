namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            decimal sum = SumOfNumbers(countOfNumbers);
            Console.WriteLine(sum);
        }
        static decimal SumOfNumbers(int countOfNumbers)
        {
            decimal sum = 0;    
            for (int i = 0; i < countOfNumbers; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            return sum;
        }
    }
}