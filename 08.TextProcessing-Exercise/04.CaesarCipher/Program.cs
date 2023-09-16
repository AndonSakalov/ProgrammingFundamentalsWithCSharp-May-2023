namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string encryptedMessage = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                int currentCharNum = message[i];
                int encryptedChar = currentCharNum + 3;
                encryptedMessage += (char)encryptedChar;
            }
            Console.WriteLine(encryptedMessage);
        }
    }
}