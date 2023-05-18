namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            bool isLowerThanTen = false;
            for (int i = times; i <= 10; i++)
            {
                isLowerThanTen = true;
                if (times <= 10)
                {
                    Console.WriteLine($"{number} X {times} = {number * times}");
                    times++;
                }
            }
            if (!isLowerThanTen)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
            }
        }
    }
}