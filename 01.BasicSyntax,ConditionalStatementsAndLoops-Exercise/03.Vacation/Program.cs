namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double pricePerPerson = 0;
            double totalPrice = 0;
            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 8.45;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46;
                            break;                                                       
                    }
                    totalPrice = pricePerPerson * countOfPeople;
                    if (countOfPeople >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 10.90;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.60;
                            break;
                        case "Sunday":
                            pricePerPerson = 16;
                            break;
                    }
                    if (countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                    }
                    totalPrice = pricePerPerson * countOfPeople;
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 15;
                            break;
                        case "Saturday":
                            pricePerPerson = 20;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50;
                            break;
                    }
                    totalPrice = pricePerPerson * countOfPeople;
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        totalPrice *= 95;
                    }
                    Console.WriteLine($"Total price: {totalPrice:F2}");
                    break;
            }
        }
    }
}