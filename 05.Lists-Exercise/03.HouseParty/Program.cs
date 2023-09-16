namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());
            int counter = 1;
            List<string> guestList = new List<string>();
            while (counter <= numberOfComands)
            {
                string input = Console.ReadLine();
                counter++;
                string[] inputArr = input.Split();
                string name = inputArr[0];
                switch (inputArr[2])
                {
                    case "going!":
                        if (!guestList.Contains(name))
                        {
                            guestList.Add(name);
                        }
                        else
                        {
                            Console.WriteLine($"{name} is already in the list!");
                        }
                        break;
                    case "not":
                        if (guestList.Contains(name))
                        { 
                            guestList.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"{name} is not in the list!");
                        }
                        break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }
        }
    }
}