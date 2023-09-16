namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elementsOfFilePath = Console.ReadLine().Split(new char[] { '\\', '.' });
            Console.WriteLine($"File name: {elementsOfFilePath[elementsOfFilePath.Length - 2]}");
            Console.WriteLine($"File extension: {elementsOfFilePath[elementsOfFilePath.Length - 1]}");
        }
    }
}