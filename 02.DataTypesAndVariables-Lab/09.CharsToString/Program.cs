namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());
            string combinedChars = $"{char1}{char2}{char3}";
            Console.WriteLine(combinedChars);
        }
    }
}