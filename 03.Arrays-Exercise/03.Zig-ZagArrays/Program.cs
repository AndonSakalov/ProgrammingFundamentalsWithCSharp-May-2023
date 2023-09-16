namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                int number1 = int.Parse(numbers[0]);
                int number2 = int.Parse(numbers[1]);
                if (i % 2 == 0)
                {
                    array1[i] = number1;
                    array2[i] = number2;
                }
                else
                {
                    array1[i] = number2;
                    array2[i] = number1;
                }
            }
            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}