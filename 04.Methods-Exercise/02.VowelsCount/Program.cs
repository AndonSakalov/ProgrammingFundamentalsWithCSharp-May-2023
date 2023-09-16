namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string singleString = Console.ReadLine();
            PrintVowelsCount(singleString);
        }

        static void PrintVowelsCount(string singleString)
        {
            int vowelsCount = 0;
            for (int i = 0; i < singleString.Length; i++)
            {
                switch (singleString[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        vowelsCount++;
                        break;
                }
            }
            Console.WriteLine(vowelsCount);
        }
    }
}