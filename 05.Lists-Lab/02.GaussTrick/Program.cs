namespace _02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> summedNumbers = new List<int>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                summedNumbers.Add(numbers[i] + numbers[numbers.Count - i - 1]);
            }

            if (numbers.Count % 2 != 0)
            {
                summedNumbers.Add(numbers[numbers.Count / 2]);
            }

            Console.Write(string.Join(" ", summedNumbers));
        }
    }
}