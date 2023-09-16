namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine();
            string str = Console.ReadLine();
            while (str.Contains(stringToRemove))
            {
                int index = str.IndexOf(stringToRemove);
                str = str.Remove(index, stringToRemove.Length);
            }
            Console.WriteLine(str);
        }
    }
}