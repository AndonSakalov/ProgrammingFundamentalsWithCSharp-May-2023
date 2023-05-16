namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            int headsetsBroken = gamesLost / 2;
            int mousesBroken = gamesLost / 3;
            int keyboardsBroken = gamesLost / 6;
            int displaysBroken = gamesLost / 12;

            double rageExpenses = headsetPrice * headsetsBroken + mousePrice * mousesBroken + keyboardPrice * keyboardsBroken + displayPrice * displaysBroken;
            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");   
        }
    }
}