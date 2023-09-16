namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> symbols = GetSymbolsFromArr(arr);
            Console.WriteLine(string.Join(" ", symbols));
        }

        static List<string> GetSymbolsFromArr(string[] arr)
        {
            List<string> result = new List<string>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                string[] array = arr[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                result.AddRange(array);
            }
            return result;
        }
    }
}