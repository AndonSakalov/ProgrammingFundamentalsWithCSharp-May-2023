namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            double orderCost = 0;
            double totalCost = 0;
            for (int i = 1; i <= ordersCount; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                orderCost = pricePerCapsule * capsulesCount * days;
                Console.WriteLine($"The price for the coffee is: ${orderCost:F2}");
                totalCost += orderCost;
            }
            Console.WriteLine($"Total: ${totalCost:F2}");
        }
    }
}