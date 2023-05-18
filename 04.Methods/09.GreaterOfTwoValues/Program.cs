namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string variableType = Console.ReadLine();
            switch (variableType)
            {
                case "int":
                    int int1 = int.Parse(Console.ReadLine());
                    int int2 = int.Parse(Console.ReadLine());
                    int biggerInt = GetMaxInt(int1, int2);
                    Console.WriteLine(biggerInt);
                    break;
                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());
                    char biggerChar = GetMaxChar(char1, char2);
                    Console.WriteLine(biggerChar);
                    break;
                case "string":
                    string string1 = Console.ReadLine();
                    string string2 = Console.ReadLine();
                    string biggerString = GetMaxString(string1, string2);
                    Console.WriteLine(biggerString);
                    break;
            }
        }
        static int GetMaxInt(int int1, int int2)
        {
            int biggerInt = default;
            if (int1 > int2)
            {
                biggerInt = int1;
            }
            else if (int2 > int1)
            {
                biggerInt = int2;
            }
            return biggerInt;
        }
        static char GetMaxChar(char char1, char char2)
        {
            char biggerChar = default;
            if (char1 > char2)
            {
                biggerChar = char1;
            }
            else if (char2 > char1)
            {
                biggerChar = char2;
            }
            return biggerChar;
        }
        static string GetMaxString(string string1, string string2)
        {
            string biggerString = default;
            int comparison = String.Compare(string1, string2);
            if (comparison == 1)
            {
                biggerString = string1;
            }
            else
            {
                biggerString = string2;
            }
            return biggerString;
        }
    }
}