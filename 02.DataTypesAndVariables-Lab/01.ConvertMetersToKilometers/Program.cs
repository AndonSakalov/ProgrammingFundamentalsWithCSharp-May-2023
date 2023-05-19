namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double metersToKilometers = MetersToKilometers(meters);
            Console.WriteLine($"{metersToKilometers:F2}");

        }
        static double MetersToKilometers(int meters)
        {
            double metersToKilometers = (double)meters / 1000.0;
            return metersToKilometers;
        }
    }
}