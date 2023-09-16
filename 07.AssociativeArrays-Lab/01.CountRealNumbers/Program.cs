namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            var numbersDictionary = new SortedDictionary<double, int>();   //key -> number | value -> containingNumber
            foreach (var number in numbers)
            {
                if (numbersDictionary.ContainsKey(number))
                {
                    numbersDictionary[number]++;
                }
                else
                {
                    numbersDictionary.Add(number, 1);
                }
            }

            foreach (var kvp in numbersDictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}