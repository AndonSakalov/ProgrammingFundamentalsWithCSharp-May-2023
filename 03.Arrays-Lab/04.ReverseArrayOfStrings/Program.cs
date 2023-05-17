namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(" ").ToArray();
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write($"{elements[elements.Length - i - 1]} ");
            }
            Console.WriteLine();
        }
    }
}