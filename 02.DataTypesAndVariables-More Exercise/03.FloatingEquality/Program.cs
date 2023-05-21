namespace _03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double esp = 0.000001;
            double diff = Math.Abs(number1 - number2);
            bool areEqual = false;
            if (diff < esp)
            {
                areEqual = true;
                Console.WriteLine(areEqual);
            }
            else
            {
                Console.WriteLine(areEqual);
            }
        }
    }
}