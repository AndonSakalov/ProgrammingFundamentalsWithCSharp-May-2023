namespace _02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int[] array = new int[countOfNumbers];
            for (int i = 0; i < countOfNumbers; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = countOfNumbers - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}