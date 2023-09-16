namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
            .Split()
            .Where(w => w.Length % 2 == 0)
            .ToList()
            .ForEach(Console.WriteLine);

        }
    }
}