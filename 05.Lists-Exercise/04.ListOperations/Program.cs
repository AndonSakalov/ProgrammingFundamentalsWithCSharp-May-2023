using System.Net;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(commands[1]);
                        AddNumber(list, numberToAdd);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commands[1]);
                        int indexToInsertAt = int.Parse(commands[2]);
                        if (indexToInsertAt < 0 || indexToInsertAt >= list.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            InsertNumber(list, numberToInsert, indexToInsertAt);
                        }
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(commands[1]);
                        if (indexToRemove < 0 || indexToRemove >= list.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            RemoveIndex(list, indexToRemove);
                        }
                        break;
                    case "Shift":
                        int count = int.Parse(commands[2]);
                        if (commands[1] == "left")
                        {
                            ShiftLeft(list, count);
                        }
                        else if (commands[1] == "right")
                        {
                            ShiftRight(list, count);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }

        static List<int> ShiftRight(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int temp = list[list.Count - 1];
                for (int j = list.Count - 1; j >= 0; j--)
                {
                    if (j != 0)
                    {
                        list[j] = list[j - 1];
                    }
                    else
                    {
                        break; 
                    }
                }
                list[0] = temp;
            }
            return list;
        }

        static List<int> ShiftLeft(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int temp = list[0];
                for (int j = 0; j < list.Count - 1; j++)
                {
                    list[j] = list[j + 1];
                }
                list[list.Count - 1] = temp;
            }
            return list;
        }

        static List<int> RemoveIndex(List<int> list, int indexToRemove)
        {
            list.RemoveAt(indexToRemove);
            return list;
        }

        static List<int> InsertNumber(List<int> list, int numberToInsert, int indexToInsertAt)
        {
            list.Insert(indexToInsertAt, numberToInsert);
            return list;
        }

        static List<int> AddNumber(List<int> list, int numberToAdd)
        {
            list.Add(numberToAdd);
            return list;
        }
    }
}