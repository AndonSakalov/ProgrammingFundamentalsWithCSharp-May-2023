namespace _02.CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double point1Part1 = double.Parse(Console.ReadLine());
            double point1Part2 = double.Parse(Console.ReadLine());
            double point2Part1 = double.Parse(Console.ReadLine());
            double point2Part2 = double.Parse(Console.ReadLine());
            PointChecker(point1Part1, point1Part2, point2Part1, point2Part2);

        }

        static void PointChecker(double point1part1, double point1part2, double point2Part1, double point2Part2)
        {
            double point1DiffFrom0 = Math.Abs(point1part1 + point1part2);
            double point2DiffFrom0 = Math.Abs(point2Part1 + point2Part1);
            if (point1DiffFrom0 < point2DiffFrom0)
            {
                Console.WriteLine($"({point1part1}, {point1part2})");
            }
            else if (point2DiffFrom0 < point1DiffFrom0)
            {
                Console.WriteLine($"({point2Part1}, {point2Part2})");
            }
            else
            {
                Console.WriteLine($"({point1part1}, {point1part2})");
            }
        }
    }
}