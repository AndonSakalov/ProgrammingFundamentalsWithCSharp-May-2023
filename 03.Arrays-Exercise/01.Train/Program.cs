namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int[] peopleInEachWagon = new int[wagonsCount];
            int totalPeopleInTheTrain = 0;
            for (int i = 0; i < wagonsCount; i++) 
            {
                peopleInEachWagon[i]= int.Parse(Console.ReadLine());
                totalPeopleInTheTrain += peopleInEachWagon[i];
            }
            Console.WriteLine(string.Join(" ", peopleInEachWagon));
            Console.WriteLine(totalPeopleInTheTrain);
        }
    }
}