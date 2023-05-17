namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] realNumbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            for (int i = 0; i < realNumbers.Length; i++)
            {
                if (realNumbers[i] == -0)
                {
                    realNumbers[i] = 0;
                }
                int roundedNumber = (int)Math.Round(realNumbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{realNumbers[i]} => {roundedNumber}");
            }
        }        
    }
}