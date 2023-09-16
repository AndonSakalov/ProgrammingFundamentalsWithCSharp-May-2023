namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfBiscuitsPerWorker = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int competingCompanyBiscuitsFor30Days = int.Parse(Console.ReadLine()); //Possible problem here (long)
            double companyBiscuits = 0;
            for (int i = 0; i < 30; i++)
            {
                if (i % 3 == 0)
                {
                    companyBiscuits += Math.Floor(workersCount * (double)(0.75 * numbersOfBiscuitsPerWorker));
                }
                else
                {
                    companyBiscuits += workersCount * numbersOfBiscuitsPerWorker;
                }
            }
            Console.WriteLine($"You have produced {companyBiscuits} biscuits for the past month.");
            double diff = Math.Abs(companyBiscuits - competingCompanyBiscuitsFor30Days);
            if (companyBiscuits > competingCompanyBiscuitsFor30Days)
            {

                Console.WriteLine($"You produce {diff / competingCompanyBiscuitsFor30Days * 100:F2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {diff / competingCompanyBiscuitsFor30Days * 100:F2} percent less biscuits.");
            }
        }
    }
}