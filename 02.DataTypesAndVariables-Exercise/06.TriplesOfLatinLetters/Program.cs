namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int startChar = 97;
            int endChar = 97 + input;
            for (int i = startChar; i < endChar; i++)
            {
                for (int j = startChar; j < endChar; j++)
                {
                    for (int k = startChar; k < endChar; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}