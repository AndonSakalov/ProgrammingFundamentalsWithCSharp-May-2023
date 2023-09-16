using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace _3.SoftUniBarIncome
{
    public class Order
    {
        public Order(string customerName, string product, int count, decimal price)
        {
            CustomerName = customerName;
            Product = product;
            Count = count;
            Price = price;
        }
        public string CustomerName { get; set; }
        public string Product { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }


        public decimal Total()
        {
            return Count * Price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<Name>[A-Z]{1}[a-z]+)%[^|$%.]*?<(?<Product>\w+)>[^|$%.]*?\|(?<Count>\d+)\|[^|$%.]*?(?<Price>\d+|\d+\.\d+)\$";
            string input;
            decimal total = 0m;
            List<Order> orders = new List<Order>();
            while ((input = Console.ReadLine()) != "end of shift")
            {
                MatchCollection matches = Regex.Matches(input, pattern);
                foreach (Match match in matches)
                {
                    string customerName = match.Groups["Name"].Value;
                    string product = match.Groups["Product"].Value;
                    int count = int.Parse(match.Groups["Count"].Value);
                    decimal price = decimal.Parse(match.Groups["Price"].Value);
                    Order order = new Order(customerName, product, count, price);
                    orders.Add(order);
                    total += order.Total();
                }
            }
            foreach (Order order in orders)
            {
                Console.WriteLine($"{order.CustomerName}: {order.Product} - {order.Total():F2}");
            }
            Console.WriteLine($"Total income: {total:F2}");
        }
    }
}