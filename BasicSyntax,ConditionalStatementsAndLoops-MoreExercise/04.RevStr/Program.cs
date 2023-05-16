namespace _04.RevStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] wordReversed = word.ToCharArray();
            Array.Reverse(wordReversed);
            Console.WriteLine(wordReversed);
        }
    }
}