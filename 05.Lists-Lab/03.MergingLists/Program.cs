namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list3 = new List<int>();
            int biggestList = 0;
            if (list1.Count >= list2.Count)
            {
                biggestList = list1.Count;
            }
            else
            {
                biggestList = list2.Count;
            }
            for (int i = 0; i < biggestList; i++)
            {
                
                if (i > list1.Count - 1)
                {
                    list3.Add(list2[i]);
                }
                else if (i > list2.Count - 1)
                {
                    list3.Add(list1[i]);
                }
                else
                {
                    list3.Add(list1[i]);
                    list3.Add(list2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", list3));
        }
    }
}