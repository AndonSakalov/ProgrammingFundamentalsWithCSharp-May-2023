using System.Drawing;
using System.Text;

namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wordLength = int.Parse(Console.ReadLine());
            string output = string.Empty;
            for (int i = 1; i <= wordLength; i++)
            {
                int number = int.Parse((Console.ReadLine()));
                int numberLength = number.ToString().Length;
                int mainDigit = number % 10;
                int offset = 0;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset = ((mainDigit - 2) * 3) + 1;
                }
                else
                {
                    offset = (mainDigit - 2) * 3;
                }
                int letterIndex = (offset + numberLength - 1) + 97;
                if (letterIndex == 91)
                {
                    letterIndex = 32;
                }
                char letter = (char)letterIndex;
                output += letter;
            }
            Console.WriteLine(output);
        }
    }
}