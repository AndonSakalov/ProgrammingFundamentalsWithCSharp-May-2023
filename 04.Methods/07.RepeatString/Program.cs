namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int repetitionTimes = int.Parse(Console.ReadLine());
            string newWord = WordRepeated(word, repetitionTimes); 
            Console.WriteLine(newWord);
        }
        private static string WordRepeated(string word, int repetitionTimes)
        {
            string newWord = string.Empty;
            for (int i = 0; i < repetitionTimes; i++)
            {
                newWord += $"{word}";
            }
            return newWord;
        }

    }
}