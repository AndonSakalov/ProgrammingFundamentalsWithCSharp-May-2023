namespace _03.GamingS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double startingMoney = balance;
            while (input != "Game Time")
            {
                
                switch (input)
                {
                    case "OutFall 4":
                        if (balance >= 39.99)
                        {
                            balance -= 39.99;
                            Console.WriteLine($"Bought {input}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (balance >= 15.99)
                        {
                            balance -= 15.99;
                            Console.WriteLine($"Bought {input}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (balance >= 19.99)
                        {
                            balance -= 19.99;
                            Console.WriteLine($"Bought {input}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (balance >= 59.99)
                        {
                            balance -= 59.99;
                            Console.WriteLine($"Bought {input}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (balance >= 29.99)
                        {
                            balance -= 29.99;
                            Console.WriteLine($"Bought {input}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance >= 39.99)
                        {
                            balance -= 39.99;
                            Console.WriteLine($"Bought {input}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                input = Console.ReadLine();
            }
            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            if (input == "Game Time")
            {
                Console.Write($"Total spent: ${startingMoney - balance:F2}. ");
                Console.WriteLine($"Remaining: ${balance:F2}");
            }
        }
    }
}