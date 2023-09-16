using System.Globalization;

namespace _01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            if (dataType == "int")
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(ManipulateDataType(number));
            }
            else if (dataType == "real")
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine($"{ManipulateDataType(number):F2}");
            }
            else if (dataType == "string")
            {
                string word = Console.ReadLine();
                Console.WriteLine(ManipulateDataType(word));
            }

        }


        static int ManipulateDataType(int number)
        {
            return number * 2;
        }
        static string ManipulateDataType(string word)
        {
            return $"${word}$";
        }
        static double ManipulateDataType(double number)
        {
            return number * 1.5;
        }
    }
}