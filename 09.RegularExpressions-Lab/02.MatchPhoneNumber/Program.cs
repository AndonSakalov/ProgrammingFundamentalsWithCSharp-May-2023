using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> phoneNumbers = new List<string>();
            foreach (Match match in matches)
            {
                phoneNumbers.Add(match.Value.ToString());
            }   
            Console.WriteLine(string.Join(", ", phoneNumbers));
        }
    }
}