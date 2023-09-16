namespace _04.SoftUniParking
{
    public class User
    {
        public User(string name, string licencePlateNumber)
        {
            Name = name;
            LicensePlateNumber = licencePlateNumber;
        }
        public string Name { get; set; }
        public string LicensePlateNumber { get; set; }

        public override string ToString()
        {
            return $"{Name} => {LicensePlateNumber}"; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            var users = new Dictionary<string, User>();
            for (int i = 0; i < commandsCount; i++)
            {
                string input = Console.ReadLine();
                string[] commandInfo = input.Split();
                string command = commandInfo[0];
                string userName = commandInfo[1];
                
                switch (command)
                {
                    case "register":
                        string licensePlateNumber = commandInfo[2];
                        User newUser = new User(userName, licensePlateNumber);
                        if (!users.ContainsKey(userName))
                        {
                            users.Add(userName, newUser);
                            Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {newUser.LicensePlateNumber}");
                        }
                        break;
                    case "unregister":
                        if (!users.ContainsKey(userName))
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        else
                        {
                            users.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully");
                        }
                        break;
                }
            }
            foreach (var user in users)
            {
                Console.WriteLine(user.Value);
            }
        }
    }
}