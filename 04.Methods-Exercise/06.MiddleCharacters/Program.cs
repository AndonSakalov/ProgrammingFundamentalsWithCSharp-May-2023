namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string singleString = Console.ReadLine();
            PrintMiddleCharactersOfString(singleString);
        }

        static void PrintMiddleCharactersOfString(string singleString)
        {
            if (singleString.Length % 2 == 0)
            {
                Console.WriteLine($"{singleString[singleString.Length / 2 - 1]}{singleString[singleString.Length / 2]}");
            }
            else
            {
                Console.WriteLine(singleString[singleString.Length / 2]);
            }
        }
    }
}