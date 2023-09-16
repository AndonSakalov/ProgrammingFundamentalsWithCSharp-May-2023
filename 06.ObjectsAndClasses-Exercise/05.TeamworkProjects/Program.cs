namespace _05.TeamworkProjects

//using System.Text;
{
    public class Team
    {
        public Team(string name, string creatorName)
        {
            Name = name;

            CreatorName = creatorName;

            Members = new List<string>();

        }

        public string Name { get; set; }

        public string CreatorName { get; set; }

        public List<string> Members { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            int teamCount = int.Parse(Console.ReadLine());

            List<Team> allTeam = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] inputForTeam = Console.ReadLine()
                    .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                string currentCreator = inputForTeam[0];
                string currentTeamNeme = inputForTeam[1];

               
                bool isTeamNameExist = allTeam
                    .Select(x => x.Name).Contains(currentTeamNeme);

                bool isCreatorExist = allTeam
                    .Any(x => x.CreatorName == currentCreator);

               
                if (isTeamNameExist == false && isCreatorExist == false)
                {
                    Team currentTeam = new Team(currentTeamNeme, currentCreator);

                    allTeam.Add(currentTeam);

                    Console.WriteLine("Team {0} has been created by {1}!", currentTeamNeme, currentCreator);
                }
                else if (isTeamNameExist)
                {
                    Console.WriteLine("Team {0} was already created!", currentTeamNeme);
                }
                else if (isCreatorExist)
                {
                    Console.WriteLine("{0} cannot create another team!", currentCreator);
                }
            }

            while (true)
            {
                string fensForTeam = Console.ReadLine();

                if (fensForTeam == "end of assignment")
                {
                    break;
                }

                string[] inputAssignment = fensForTeam
                    .Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string fen = inputAssignment[0];

                string ofFensTeam = inputAssignment[1];

                bool isTeamExist = allTeam.Any(x => x.Name == ofFensTeam);

               
                bool isCreatorCheating = allTeam.Any(x => x.CreatorName == fen);
                bool isAlreadyFen = allTeam.Any(x => x.Members.Contains(fen));

                if (isTeamExist && isCreatorCheating == false && isAlreadyFen == false)
                {
                    int indexOfTeam = allTeam
                        .FindIndex(x => x.Name == ofFensTeam);

                    allTeam[indexOfTeam].Members.Add(fen);
                }
                else if (isTeamExist == false)
                {
                    Console.WriteLine("Team {0} does not exist!", ofFensTeam);
                }
                else if (isAlreadyFen || isCreatorCheating)
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", fen, ofFensTeam);
                }
            } 

            List<Team> teamWithMember = allTeam
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)
                .ToList();

            List<Team> notValidTeam = allTeam
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var team in teamWithMember)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.CreatorName);
                team.Members.Sort();
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => "-- " + x)));
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in notValidTeam)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}