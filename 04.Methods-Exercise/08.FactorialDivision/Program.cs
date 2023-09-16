namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer1 = int.Parse(Console.ReadLine());
            int integer2 = int.Parse(Console.ReadLine());
            double integer1Factorial = Factorial(integer1);
            double integer2Facotiral = Factorial(integer2);
            Console.WriteLine($"{FactorialDivision(integer1Factorial, integer2Facotiral):F2}");
        }

        static double FactorialDivision(double factorial1, double factorial2)
        {
            return factorial1 / factorial2;
        }

        static double Factorial(int number)
        {
            double factorial = 1;
            for (int i = 1; i <= number ; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}