namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());
            int courses = 0;
            while (countOfPeople > 0)
            {
                countOfPeople -= capacityOfElevator;
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}