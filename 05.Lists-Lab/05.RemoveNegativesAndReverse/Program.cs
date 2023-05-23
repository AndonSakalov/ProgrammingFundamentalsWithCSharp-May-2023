using System.Collections.Generic;

namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            List<int> list2 = ReverseSort(list);
            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", list));
            }
            
        }
        static List<int> ReverseSort(List<int> list)
        {
            for (int i = 0; i < list.Count / 2; i++)
            {
                int temp = list[i];
                list[i] = list[list.Count - i-1];
                list[list.Count - i -1] = temp;
            }
            return list;
        }
    }
}