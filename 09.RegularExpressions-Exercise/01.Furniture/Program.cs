using System.Text.RegularExpressions;

namespace _01.Furniture
{
    public class Furniture
    {
        public Furniture(string name, decimal price, int quantity) 
        {
            Name = name;
            Price = price;  
            Quantity = quantity;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total()
        {
            return Quantity * Price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> furnitureList = new List<Furniture>();
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+|\d+\.\d+)!(?<quantity>\d+)";
            string input;
            while ((input = Console.ReadLine())!="Purchase")
            {
                Regex regex = new Regex(pattern);
                MatchCollection matchCollection = regex.Matches(input);
                foreach (Match match in matchCollection)
                {
                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    Furniture f = new Furniture(name,price,quantity);
                    furnitureList.Add(f);
                }
            }
            Console.WriteLine("Bought furniture:");
            decimal total = default;
            foreach (var f in furnitureList)
            {
                Console.WriteLine(f.Name.ToString());
                total += f.Total();
            }
            Console.WriteLine($"Total money spend: {total:F2}");
        }
    }
}