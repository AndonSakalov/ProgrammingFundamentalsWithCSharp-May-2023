namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            char mathOperation = char.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double sum = MathematicalOperation(number1, mathOperation, number2);
            Console.WriteLine(sum);
        }
        static double MathematicalOperation(double number1, char mathOperation, double number2)
        {
            double sum = 0;
            if (mathOperation == '/')
            {
                sum = number1 / number2;
            }
            else if (mathOperation == '*')
            {
                sum = number1 * number2;
            }
            else if (mathOperation == '+')
            {
                sum = number1 + number2;
            }
            else if (mathOperation == '-')
            {
                sum = number1 - number2;
            }
            return sum;
        }
    }
}