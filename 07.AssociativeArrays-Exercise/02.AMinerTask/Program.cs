namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfOre;
            var oreMap = new Dictionary<string, int>();
            while ((typeOfOre = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!oreMap.ContainsKey(typeOfOre))
                {
                    oreMap.Add(typeOfOre, quantity);
                }
                else
                {
                    oreMap[typeOfOre] += quantity;
                }
            }

            foreach (var kvp in oreMap)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}