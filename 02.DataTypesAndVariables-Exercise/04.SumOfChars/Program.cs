namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfChars = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < countOfChars; i++) 
            {
                char chars = char.Parse(Console.ReadLine());
                sum += (int)chars;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}