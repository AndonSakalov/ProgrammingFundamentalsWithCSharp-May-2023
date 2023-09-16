using System.Text.RegularExpressions;

namespace _02.Race
{
    public class Racer
    {
        public Racer(string name, decimal distance) 
        {
            Name = name;
            Distance = distance;
        }
        public string Name { get; set; }
        public decimal Distance { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ").ToList();
            List<Racer> racers = new List<Racer>();
            string input;
            string letterPattern = @"[A-Za-z]";
            string digitsPattern = @"\d";
            foreach (string participant in participants)
            {
                Racer racer = new Racer(participant, 0m);
                racers.Add(racer);
            }

            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection lettersMatches = Regex.Matches(input, letterPattern);
                string name = "";
                foreach (Match lettersMatch in lettersMatches)
                {
                    name += lettersMatch; 
                }

                MatchCollection digitsMatches = Regex.Matches(input, digitsPattern);
                decimal distance = 0m;
                foreach (Match digitsMatch in digitsMatches)
                {
                    distance += decimal.Parse(digitsMatch.Value);
                }

                if (participants.Contains(name))
                {
                    Racer foundRacer = racers.FirstOrDefault(r => r.Name == name.ToString());
                    foundRacer.Distance += distance;
                }
            }

            List<Racer> orderedRacers = racers.OrderByDescending(r => r.Distance).Take(3).ToList();
            Console.WriteLine($"1st place: {orderedRacers[0].Name}");
            Console.WriteLine($"2nd place: {orderedRacers[1].Name}");
            Console.WriteLine($"3rd place: {orderedRacers[2].Name}");
        }
    }
}