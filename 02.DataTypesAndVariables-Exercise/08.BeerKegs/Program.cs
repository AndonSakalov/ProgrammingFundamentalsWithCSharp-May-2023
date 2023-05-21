namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte beerKegs = byte.Parse(Console.ReadLine());
            double biggestVolume = 0;
            string biggestKeg = default;
            for (int i = 0; i < beerKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (i == 0)
                {
                    biggestVolume = volume;
                }
                if (biggestVolume < volume)
                {
                    biggestVolume = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}