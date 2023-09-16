namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string otherChars = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    digits += str[i];
                }
                else if (char.IsLetter(str[i]))
                {
                    letters += str[i];
                }
                else
                {
                    otherChars += str[i];
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}