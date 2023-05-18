namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calculationType = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (calculationType == "add")
            {
                Add(number1, number2);
            }
            if (calculationType == "multiply")
            {
                Multiply(number1, number2);
            }
            if (calculationType == "subtract")
            {
                Subtract(number1, number2);    
            }
            if (calculationType == "divide")
            {
                Divide(number1, number2);
            }
        }
        static void Add(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
        static void Multiply(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }
        static void Subtract(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }
        static void Divide(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
        }
    }
}