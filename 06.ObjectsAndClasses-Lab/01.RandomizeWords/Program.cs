namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split().ToArray();
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int randomIndex = rnd.Next(0,arr.Length);
                string temp = arr[i];
                arr[i] = arr[randomIndex];
                arr[randomIndex] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}