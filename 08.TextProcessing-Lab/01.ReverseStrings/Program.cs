namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            while ((word = Console.ReadLine()) != "end")
            {
                string reversedWord = "";
                for (int i = word.Length -1; i >= 0; i--)
                {
                    reversedWord = reversedWord + word[i];
                }
                Console.WriteLine($"{word} = {reversedWord}");
            }
        }
    }
}