using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[A-Z]{1}[a-z]+\s{1}[A-Z][a-z]+\b";
            MatchCollection matches = Regex.Matches(input, pattern);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.Write(match.Value + " ");
                }
                Console.WriteLine();
            }
        }
    }
}