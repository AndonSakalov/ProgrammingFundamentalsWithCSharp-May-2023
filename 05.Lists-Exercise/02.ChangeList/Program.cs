namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Delete":
                        int elementToDelete = int.Parse(command[1]);
                        DeleteElements(elementToDelete, list);
                        break;
                    case "Insert":
                        int elementToInsert = int.Parse(command[1]);
                        int insertIndex = int.Parse(command[2]);
                        InsertElement(elementToInsert, list , insertIndex);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }

        static List<int> InsertElement(int elementToInsert, List<int> list, int insertIndex)
        {
            list.Insert(insertIndex, elementToInsert);
            return list;
        }

        static List<int> DeleteElements(int elementToDelete, List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == elementToDelete)
                { 
                    list.RemoveAt(i);
                    i--;
                }
            }
            return list;
        }
    }
}