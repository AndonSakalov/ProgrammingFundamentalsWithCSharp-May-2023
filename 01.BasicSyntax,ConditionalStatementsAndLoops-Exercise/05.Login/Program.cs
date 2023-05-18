namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] stringArray = username.ToCharArray();
            Array.Reverse(stringArray);
            char[] chars = stringArray;
            string correctPassword = new string(chars);
            string password = Console.ReadLine();
            int tries = 0;
            while (password != correctPassword)
            {
                tries++;
                if (tries == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
            }
            if (password == correctPassword)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}