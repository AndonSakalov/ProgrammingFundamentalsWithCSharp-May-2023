namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal usd = PoundsToDollars(pounds);
            Console.WriteLine($"{usd:F3}");
        }
        static decimal PoundsToDollars(decimal pounds)
        {
            decimal usd = pounds * 1.31m;
            return usd;
        }
    }
}