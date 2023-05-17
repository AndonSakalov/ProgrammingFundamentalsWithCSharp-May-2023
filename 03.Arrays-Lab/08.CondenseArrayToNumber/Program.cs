namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensedArray = new int[numbers.Length];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < condensedArray.Length - 1; j++)
                {
                    condensedArray[j] = numbers[j] + numbers[j + 1];
                    numbers[j] = condensedArray[j];
                }
            } 
          
            Console.WriteLine(numbers[0]);

        }
    }
}