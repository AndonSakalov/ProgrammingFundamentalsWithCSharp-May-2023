namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string longestSequenceNumbers = "";
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                string sequenceNumbers = $"{arr[i]}";
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        sequenceNumbers += $" {arr[j]}";
                        if (  sequenceNumbers.Length >= longestSequenceNumbers.Length)
                        {
                            longestSequenceNumbers = sequenceNumbers;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(longestSequenceNumbers);
        }
    }
}