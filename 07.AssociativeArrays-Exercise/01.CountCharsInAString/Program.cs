namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var characters = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    continue;
                }

                if (!characters.ContainsKey(input[i]))
                {
                    characters.Add(input[i], 1);
                }

                else
                {
                    characters[input[i]]++;
                }
            }
            foreach (KeyValuePair<char, int> kvp in characters)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}