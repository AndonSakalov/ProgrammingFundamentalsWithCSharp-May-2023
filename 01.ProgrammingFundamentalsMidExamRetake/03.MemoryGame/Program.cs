using System.Transactions;

namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int [] arr = Console.ReadLine().Split("!@").Select(int.Parse).ToArray();
            //Console.WriteLine(string.Join(" ", arr));
            double[] arr = new double[7];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            double sum = arr.Sum();
            Console.WriteLine(sum / arr.Length);
            //List<string> elements = Console.ReadLine().Split().ToList();
            //string input = Console.ReadLine();
            //int moves = 1;
            //while (input != "end")
            //{
            //    int[] tokens = input.Split(" ").Select(int.Parse).ToArray();
            //    if (tokens[0] == tokens[1] || tokens[0] < 0 || tokens[1] < 0)
            //    {
            //        Console.WriteLine("Invalid input! Adding additional elements to the board");
            //        for (int i = 0; i < moves; i++)
            //        {
            //            elements.Insert(elements.Count / 2,$"-{moves}a");
            //        }

            //    }
            //    else if (elements[tokens[0]] == elements[tokens[1]])
            //    {
            //        Console.WriteLine($"Congrats! You have found matching elements - {elements[tokens[0]]}!");
            //        if (elements[tokens[0]].CompareTo(elements[tokens[1]]) > 0 )
            //        {
            //            if (tokens[0] - tokens[1] > 1)
            //            {
            //                elements.RemoveAt(tokens[0]);
            //                elements.RemoveAt(tokens[1]);
            //            }
            //            else
            //            {
            //                elements.RemoveAt(tokens[1]);
            //                elements.RemoveAt(tokens[0]);
            //            }

            //        }
            //        else
            //        {
            //            if (tokens[0] - tokens[1] > 1)
            //            {
            //                elements.RemoveAt(tokens[1]);
            //                elements.RemoveAt(tokens[0]);
            //            }
            //            else
            //            {
            //                elements.RemoveAt(tokens[0]);
            //                elements.RemoveAt(tokens[1]);
            //            }
            //        }
            //    }
            //    else if (!(elements[tokens[0]].CompareTo(elements[tokens[1]]) > 0))
            //    {
            //        Console.WriteLine("Try again!");
            //    }
            //    if (elements.Count == 0)
            //    {
            //        Console.WriteLine($"You have won in {moves} turns!");
            //        return;
            //    }
            //    input = Console.ReadLine();
            //    moves++;
            //}
            //if (elements.Count > 0)
            //{
            //    Console.WriteLine($"Sorry you lose :(\n{string.Join(" ", elements)}");
            //}
        }
    }
}