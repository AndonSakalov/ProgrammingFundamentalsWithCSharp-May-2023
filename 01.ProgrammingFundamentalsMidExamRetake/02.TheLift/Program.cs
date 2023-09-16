namespace _02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInQueue = int.Parse(Console.ReadLine());
            List<int> lifts = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = 0;
            bool peopleInQueueEqual0 = false;
            for (int i = 0; i < lifts.Count; i++)
            {
                capacity += lifts[i];
            }
            while (peopleInQueue > 0 && capacity < lifts.Count * 4)
            {
                for (int i = 0; i < lifts.Count; i++)
                {
                    while (lifts[i] < 4)
                    {
                        lifts[i] += 1;
                        peopleInQueue--;
                        capacity++;
                        if (peopleInQueue == 0)
                        {
                            peopleInQueueEqual0 = true;
                            break;
                        }
                    }
                    if (peopleInQueueEqual0)
                    {
                        break;
                    }
                }
            }
            if (peopleInQueue == 0 && capacity < lifts.Count * 4)
            {
                Console.WriteLine($"The lift has empty spots!\n{string.Join(" ", lifts)}");
            }
            if (peopleInQueue > 0 && capacity == lifts.Count * 4)
            {
                Console.WriteLine($"There isn't enough space! {peopleInQueue} people in a queue!\n{string.Join(" ", lifts)}");
            }
            if ((peopleInQueue == 0 && capacity == lifts.Count * 4))
            {
                Console.WriteLine(string.Join(" ", lifts));
            }
        }
    }
}