namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int nOriginalValue = n;
            int pokesCount = 0;
            //CALCULATIONS
            while (n >= m)
            {
                n -= m;
                pokesCount++;
                if (n == 0.5 * nOriginalValue && y > 0)
                {
                    n /= y;
                }
            }
            //OUTPUT
            Console.WriteLine(n);
            Console.WriteLine(pokesCount);
        }
    }
}