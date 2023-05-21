namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());    
            int charsCount = int.Parse(Console.ReadLine());
            int decryptedChar = 0;
            string decryptedMessage = default;
            for (int i = 0; i < charsCount; i++) 
            {
                char character = char.Parse(Console.ReadLine());
                decryptedChar = (int)character + key;
                decryptedMessage += (char)decryptedChar;
                
            }
            Console.WriteLine(decryptedMessage);
        }
    }
}