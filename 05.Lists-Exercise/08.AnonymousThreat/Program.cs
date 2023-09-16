namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arrayOfData = Console.ReadLine().Split().ToList();
            string input = "";
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "merge":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);
                        arrayOfData = MergeElementsOfArray(arrayOfData, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(commands[1]);
                        int partitions = int.Parse(commands[2]);
                        arrayOfData = DivideElementsOfArray(arrayOfData, index, partitions);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", arrayOfData));
        }

        private static List<string> DivideElementsOfArray(List<string> arrayOfData, int index, int partitions)
        {
            List<char> subStringsOfElement = arrayOfData[index].ToList();
            arrayOfData.RemoveAt(index);
            int initialSubStringListCount = subStringsOfElement.Count;
            for (int i = 0; i < partitions; i++)
            {
                string currentStr = "";
                if (initialSubStringListCount % partitions == 0)
                {
                    for (int j = 0; j < initialSubStringListCount / partitions; j++)
                    {
                        currentStr += subStringsOfElement[j];
                    }
                    subStringsOfElement.RemoveRange(0, initialSubStringListCount / partitions);
                    if (index < arrayOfData.Count)
                    {
                        arrayOfData.Insert(index, currentStr);
                        index++;
                    }
                    else
                    {
                        arrayOfData.Add(currentStr);
                        index++;
                    }
                }
                else
                {
                    for (int k = 0; k < initialSubStringListCount / partitions; k++)
                    {
                        
                        if (i == partitions - 1)
                        {
                            for (int z = 0; z < subStringsOfElement.Count; z++)
                            {
                                currentStr += subStringsOfElement[z];
                            }
                            break;
                        }
                        else
                        {
                            currentStr += subStringsOfElement[k];
                        }
                    }
                    subStringsOfElement.RemoveRange(0, initialSubStringListCount / partitions);
                    if (index < arrayOfData.Count)
                    {
                        arrayOfData.Insert(index, currentStr);
                        index++;
                    }
                    else
                    {
                        arrayOfData.Add(currentStr);
                        index++;
                    }
                }
            }
            return arrayOfData;
        }

        static List<string> MergeElementsOfArray(List<string> arrayOfData, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex > arrayOfData.Count - 1)
            {
                endIndex = arrayOfData.Count - 1;
            }
            int counter = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (counter == endIndex - startIndex)
                {
                    break;
                }
                if (i + 1 < arrayOfData.Count)
                {
                    arrayOfData[i] += arrayOfData[i + 1];
                    arrayOfData.RemoveAt(i + 1);
                    i--;
                    counter++;
                }
            }
            return arrayOfData;
        }
    }
}