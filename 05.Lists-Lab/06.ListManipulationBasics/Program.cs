namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine(string.Join(" ",list));
                    break;
                }
                string[] tokens = input.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int numbersToAdd = int.Parse(tokens[1]);
                        list.Add(numbersToAdd);
                        break;
                    case "Remove":
                        int numbersToRemove = int.Parse(tokens[1]);
                        list.Remove(numbersToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        list.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        list.Insert(indexToInsert, numberToInsert);
                        break;
                }
            }
        }
    }
}