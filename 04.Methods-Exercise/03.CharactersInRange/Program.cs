namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            PrintCharactersInbetweenChar1AndChar2(char1, char2);
        }

        static void PrintCharactersInbetweenChar1AndChar2(char char1, char char2)
        {
            int char1Number = char1;
            int char2Number = char2;
            if (char1Number > char2Number)
            {
                int temp = char1Number;
                char1Number = char2Number;
                char2Number = temp;
            }
            for (int i = char1Number + 1; i < char2Number; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}