namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var synonims = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();
                if (synonims.ContainsKey(word) == false)
                {
                    synonims.Add(word, new List<string>());
                    synonims[word].Add(synonim);
                }
                else
                {
                     synonims[word].Add(synonim);
                }
            }
            foreach (var kvp in synonims)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }

        }
    }
}