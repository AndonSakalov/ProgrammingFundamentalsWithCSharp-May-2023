namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalMoney = 0;
            while (input != "Start")
            {
                double coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    totalMoney += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (totalMoney >= 2.0)
                        {
                            totalMoney -= 2.0;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (totalMoney >= 0.7)
                        {
                            totalMoney -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (totalMoney >= 1.5)
                        {
                        totalMoney -= 1.5;
                        Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (totalMoney >= 0.8)
                        {
                        totalMoney -= 0.8;
                        Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (totalMoney >= 1.0)
                        {
                        totalMoney -= 1.0;
                        Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalMoney:F2}");
        }
    }
}