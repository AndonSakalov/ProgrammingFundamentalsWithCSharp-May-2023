namespace _03.Orders
{
    public class Product
    {
        public Product(string name, decimal price, int quantity)
        {
            Name = name; 
            Price = price;
            Quantity = quantity;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Name} -> {Quantity * Price:F2}".Trim();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            var orders = new Dictionary<string, Product>();
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] productInfo = input.Split();
                string productName = productInfo[0];
                decimal price = decimal.Parse(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);
                Product newProduct = new Product(productName, price, quantity);
                if (!orders.ContainsKey(productName))
                {
                    orders.Add(newProduct.Name, newProduct);
                }
                else
                {
                    Product existingProduct = orders[newProduct.Name];
                    existingProduct.Price = price;
                    existingProduct.Quantity += quantity;
                }
            }
            foreach (var kvp in orders)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }
}