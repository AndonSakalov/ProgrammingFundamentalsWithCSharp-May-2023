using System.Globalization;

namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] dayOfWeek = new string[7]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            if (number>= 1 && number <= 7)
            {
                Console.WriteLine(dayOfWeek[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }           
        }
    }
}