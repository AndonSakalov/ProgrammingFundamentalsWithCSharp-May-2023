using System.Globalization;
using System.Net;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isChanged = false;
            while (true)
            {       
                string input = Console.ReadLine();
                if (input == "end")
                {
                    if (isChanged == true)
                    {
                        Console.WriteLine(string.Join(" ", list));
                    }
                    break;
                }
                string[] tokens = input.Split(); 
                switch (tokens[0])
                {
                    case "Contains":
                        int numberToCheck = int.Parse(tokens[1]);
                        bool contains = false;
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (numberToCheck == list[i])
                            {
                                contains = true;
                            }
                        }
                        if (contains)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> evenNumbers = new List<int>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (!(list[i] % 2 != 0))
                            {
                                evenNumbers.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", evenNumbers));
                        break;
                    case "PrintOdd":
                        List<int> oddNumbers = new List<int>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] % 2 != 0)
                            {
                                oddNumbers.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", oddNumbers));
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sum += list[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        int filteringNumber = int.Parse(tokens[2]);
                        List<int> filteredList1 = new List<int>();
                        if (tokens[1] == "<")
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] < filteringNumber)
                                {
                                    filteredList1.Add(list[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredList1));
                        }
                        else if (tokens[1] == ">")
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] > filteringNumber)
                                {
                                    filteredList1.Add(list[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredList1));
                        }
                        else if (tokens[1] == ">=")
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] >= filteringNumber)
                                {
                                    filteredList1.Add(list[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredList1));
                        }
                        else if (tokens[1] == "<=")
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] <= filteringNumber)
                                {
                                    filteredList1.Add(list[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredList1));
                        }
                        break;
                    case "Add":
                        isChanged = true;
                        int numbersToAdd = int.Parse(tokens[1]);
                        list.Add(numbersToAdd);
                        break;
                    case "Remove":
                        isChanged = true;
                        int numbersToRemove = int.Parse(tokens[1]);
                        list.Remove(numbersToRemove);
                        break;
                    case "RemoveAt":
                        isChanged = true;
                        int indexToRemove = int.Parse(tokens[1]);
                        list.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        isChanged = true;
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        list.Insert(indexToInsert, numberToInsert);
                        break;
                }
            }
        }
    }
}