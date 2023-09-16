namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string output = string.Empty;
            foreach (string word in words) 
            {
                for (int i = 0; i < word.Length; i++)
                {
                    output += word;
                }
            }
            Console.WriteLine(output);
        }
    }
}