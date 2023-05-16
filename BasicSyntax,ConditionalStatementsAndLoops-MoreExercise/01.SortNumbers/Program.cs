namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double numberThree = double.Parse(Console.ReadLine());
            double maxNumber = 0;
            double minNumber = 0;
            if (numberOne >= numberTwo && numberOne >= numberThree)
            {
                maxNumber = numberOne;
                if (numberTwo >= numberThree)
                {
                    minNumber = numberThree;
                    Console.WriteLine(maxNumber);
                    Console.WriteLine(numberTwo);
                    Console.WriteLine(minNumber);
                }
                else
                {
                    minNumber = numberTwo;
                    Console.WriteLine(maxNumber);
                    Console.WriteLine(numberThree);
                    Console.WriteLine(minNumber);
                }
            }
            if (numberTwo >= numberOne && numberTwo >= numberThree)
            {
                maxNumber = numberTwo;
                if (numberOne >= numberThree)
                {
                    minNumber = numberThree;
                    Console.WriteLine(maxNumber);
                    Console.WriteLine(numberOne);
                    Console.WriteLine(minNumber);
                }
                else
                {
                    minNumber = numberOne;
                    Console.WriteLine(maxNumber);
                    Console.WriteLine(numberThree);
                    Console.WriteLine(minNumber);
                }
            }
            if (numberThree >= numberTwo && numberThree >= numberOne)
            {
                maxNumber = numberThree;
                if (numberTwo >= numberOne)
                {
                    minNumber = numberOne;
                    Console.WriteLine(maxNumber);
                    Console.WriteLine(numberTwo);
                    Console.WriteLine(minNumber);
                }
                else
                {
                    minNumber = numberTwo;
                    Console.WriteLine(maxNumber);
                    Console.WriteLine(numberOne);
                    Console.WriteLine(minNumber);
                }
            }
        }
    }
}