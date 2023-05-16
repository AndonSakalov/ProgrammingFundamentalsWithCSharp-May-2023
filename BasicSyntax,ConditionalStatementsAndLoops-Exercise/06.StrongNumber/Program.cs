namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int comparingNumber = number;
            int sum = 0;
            int factorialNumber = 1;
            int eachDigit = 0;
            while (number > 0)
            {
                eachDigit = number % 10;
                while (eachDigit > 0)
                {
                    factorialNumber *= eachDigit;
                    if (eachDigit == 0)
                    {
                        factorialNumber++;
                    }
                    eachDigit--;
                }
                sum += factorialNumber;
                factorialNumber = 1;
                number /= 10;
            }
            if (comparingNumber == sum)
            {
                Console.WriteLine("yes");
            }
            else 
            {
                Console.WriteLine("no");
            }
        }
    }
}