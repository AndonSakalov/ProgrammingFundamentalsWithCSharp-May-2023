namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
            var counts = new Dictionary<string, int>();
            foreach (string element in elements)
            {
                if (counts.ContainsKey(element))
                {
                    counts[element]++;
                }
                else
                {
                    counts.Add(element, 1);
                }
            }
            foreach (var kvp in counts)
            {
                if (!(kvp.Value % 2 == 0))
                {
                    Console.Write(kvp.Key + " ");
                }
            }
        }
    }
}