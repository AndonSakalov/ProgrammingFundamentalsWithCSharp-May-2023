namespace _03.LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1st Line
            double line1Point1Part1 = double.Parse(Console.ReadLine());
            double line1Point1Part2 = double.Parse(Console.ReadLine());
            double line1Point2Part1 = double.Parse(Console.ReadLine());
            double line1Point2Part2 = double.Parse(Console.ReadLine());
            //2nd Line  
            double line2Point1Part1 = double.Parse(Console.ReadLine());
            double line2Point1Part2 = double.Parse(Console.ReadLine());
            double line2Point2Part1 = double.Parse(Console.ReadLine());
            double line2Point2Part2 = double.Parse(Console.ReadLine());
            PointChecker(line1Point1Part1, line1Point1Part2, line1Point2Part1, line1Point2Part2,
                line2Point1Part1, line2Point1Part2, line2Point2Part1, line2Point2Part2);
        }

        static void PointChecker(double line1Point1Part1, double line1Point1Part2, double line1Point2Part1, double line1Point2Part2, double line2Point1Part1, double line2Point1Part2, double line2Point2Part1, double line2Point2Part2)
        {
            double line1Length = Math.Abs(line1Point1Part1 + line1Point1Part2) + Math.Abs(line1Point2Part1 + line1Point2Part2);
            double line2Length = Math.Abs(line2Point1Part1 + line2Point1Part2) + Math.Abs(line2Point2Part1 + line2Point2Part2);
            if (line1Length > line2Length)
            {
                if (Math.Abs(line1Point1Part1 + line1Point1Part2) <= Math.Abs(line1Point2Part1 + line1Point2Part2))
                {
                    Console.WriteLine($"({line1Point1Part1}, {line1Point1Part2})({line1Point2Part1}, {line1Point2Part2})");
                }
                else
                {
                    Console.WriteLine($"({line1Point2Part1}, {line1Point2Part2})({line1Point1Part1}, {line1Point1Part2})");
                }

            }
            else if (line2Length > line1Length)
            {
                if (Math.Abs(line2Point1Part1 + line2Point1Part2) <= Math.Abs(line2Point2Part1 + line2Point2Part2))
                {
                    Console.WriteLine($"({line2Point1Part1}, {line2Point1Part2})({line2Point2Part1}, {line2Point2Part2})");
                }
                else
                {
                    Console.WriteLine($"({line2Point2Part1}, {line2Point2Part2})({line2Point1Part1}, {line2Point1Part2})");
                }
            }
            else
            {
                if (Math.Abs(line1Point1Part1 + line1Point1Part2) <= Math.Abs(line1Point2Part1 + line1Point2Part2))
                {
                    Console.WriteLine($"({line1Point1Part1}, {line1Point1Part2})({line1Point2Part1}, {line1Point2Part2})");
                }
                else
                {
                    Console.WriteLine($"({line1Point2Part1}, {line1Point2Part2})({line1Point1Part1}, {line1Point1Part2})");
                }
            }
        }
    }
}