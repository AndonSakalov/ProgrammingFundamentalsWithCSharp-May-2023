namespace _01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal sum = 0m;
            decimal taxes = 0m;
            decimal totalPrice = 0m;
            while (input != "special" && input != "regular")
            {
                decimal componentPrice = decimal.Parse(input);
                if (componentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    taxes += 0.2m * componentPrice;
                    sum += componentPrice;
                }
                input = Console.ReadLine();
                if (input == "special")
                {
                    totalPrice = sum + taxes;
                    totalPrice *= 0.9m;
                }
                if (input == "regular")
                {
                    totalPrice = sum + taxes;
                }
            }
            if (totalPrice > 0)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:F2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}