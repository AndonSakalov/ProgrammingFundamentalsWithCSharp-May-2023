namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int spiceGathered = 0;
            while (yield >= 100)
            {
                days++;
                spiceGathered += yield;
                spiceGathered -= 26;      
                yield -= 10;
            }
            if (spiceGathered >= 26)
            {
                spiceGathered -= 26;
            }
            else
            {
                spiceGathered = 0;
            }
            Console.WriteLine(days);
            Console.WriteLine(spiceGathered);
        }

}
}