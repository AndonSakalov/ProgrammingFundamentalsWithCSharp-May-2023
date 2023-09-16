namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer1 = int.Parse(Console.ReadLine());
            int integer2 = int.Parse(Console.ReadLine());
            int integer3 = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintSmallestInteger(integer1, integer2, integer3));

        }

        static int PrintSmallestInteger(int number1, int number2, int number3)
        {
            int smallestNumber = 0;
            if (number1 < number2 && number1 < number3)
            {
                smallestNumber = number1;
            }
            else if (number2 < number1 && number2 < number3)
            {
                smallestNumber = number2;
            }
            else
            {
                smallestNumber = number3;
            }
            return smallestNumber;
        }
    }
}