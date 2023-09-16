namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacityForEachWagon = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine())!= "end")
            {
                string[] tokens = input.Split();
                if (tokens.Length == 1)
                {
                    int passangers = int.Parse(tokens[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passangers <= maxCapacityForEachWagon)
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }
                }
                else if (tokens.Length == 2)
                {
                    
                    wagons.Add(int.Parse(tokens[1]));
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}