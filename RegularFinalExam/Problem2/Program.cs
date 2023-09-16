using System.Text.RegularExpressions;

namespace Problem2
{
    /*

    */
    public class Boss
    {
        public Boss(string bossName, string bossTitle, int strength, int armor)
        {
            BossName = bossName;
            BossTitle = bossTitle;
            Strength = strength;
            Armor = armor;
        }
        public string BossName { get; set; }
        public string BossTitle { get; set; }
        public int Strength { get; set; }
        public int Armor { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLinesCount = int.Parse(Console.ReadLine());
            List<Boss> bosses = new List<Boss>();
            int bossCount = -1;
            string pattern = @"\|(?<BossName>[A-Z]{4,})\|:#(?<Title>[A-Za-z]+ [A-Z]?[a-z]+)#";
            for (int i = 0; i < inputLinesCount; i++)
            {
                string line = Console.ReadLine();
                MatchCollection matches = Regex.Matches(line, pattern);
                foreach (Match match in matches)
                {
                    string bossName = match.Groups["BossName"].Value;
                    string bossTitle = match.Groups["Title"].Value;
                    int strength = bossName.Length;
                    int armor = bossTitle.Length;
                    Boss boss = new Boss(bossName, bossTitle, strength, armor);
                    bossCount++;
                    bosses.Add(boss);
                }
                if (matches.Count >= 1)
                {
                    Console.WriteLine($"{bosses[bossCount].BossName}, The {bosses[bossCount].BossTitle}");
                    Console.WriteLine($">> Strength: {bosses[bossCount].Strength}");
                    Console.WriteLine($">> Armor: {bosses[bossCount].Armor}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}