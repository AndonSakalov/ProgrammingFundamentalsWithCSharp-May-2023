namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangleSize = int.Parse(Console.ReadLine());
            HalfTriangle(triangleSize);
            SecondHalfOfTheTriangle(triangleSize);
        }
        static void HalfTriangle(int triangleSize)
        {
            for (int i = 1; i <= triangleSize; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
        static void SecondHalfOfTheTriangle(int triangleSize)
        {
            for (int i = triangleSize - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}