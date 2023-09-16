namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer1 = int.Parse(Console.ReadLine());
            int integer2 = int.Parse(Console.ReadLine());
            int integer3 = int.Parse(Console.ReadLine());
            int sum = Integer1AndInteger2Sum(integer1, integer2);
            Console.WriteLine(SubtractThirdIntegerFromSum(sum, integer3));


        }

        static int SubtractThirdIntegerFromSum(int sum, int number3)
        {
            return sum - number3;
        }

        static int Integer1AndInteger2Sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}