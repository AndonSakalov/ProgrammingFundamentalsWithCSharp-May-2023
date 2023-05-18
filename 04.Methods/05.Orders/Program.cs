using System.Net.Http.Headers;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal price = 0;
            PriceCalculator(product, quantity, price);
        }
        static void PriceCalculator(string product, int quantity, decimal price)
        {
            if (product == "coffee")
            {
                price = 1.5m;
            }
            else if (product == "water")
            {
                price = 1.00m;
            }
            else if (product == "coke")
            {
                price = 1.40m;
            }
            else if (product == "snacks")
            {
                price = 2.00m;
            }
            Console.WriteLine($"{price * quantity:F2}");
        }

    }
}