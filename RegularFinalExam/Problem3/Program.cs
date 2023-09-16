namespace Problem3
{
    public class User
    {
        public User(string userName, int sentMessages, int recievedMessages)
        {
            Username = userName;
            SentMessages = sentMessages;
            RecievedMessages = recievedMessages;
        }
        public string Username { get; set; }
        public int SentMessages { get; set; }
        public int RecievedMessages { get; set; }

        public int Total()
        {
            return SentMessages + RecievedMessages;
        }
    }
    /*

    */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            int capacity = int.Parse(Console.ReadLine()); //Total sent and revieved messages
            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] commandTokens = input.Split("=");
                switch (commandTokens[0])
                {
                    case "Add":
                        string userName = commandTokens[1];
                        bool userAlreadyExist = false;
                        foreach (var user in users)
                        {
                            if (user.Username == userName)
                            {
                                userAlreadyExist = true;
                                break;
                            }
                        }
                        if (!userAlreadyExist)
                        {
                            int sentMessages = int.Parse(commandTokens[2]);
                            int recievedMessages = int.Parse(commandTokens[3]);
                            User user = new User(userName, sentMessages, recievedMessages);
                            users.Add(user);
                        }
                        break;
                    case "Message":
                        string sender = commandTokens[1];
                        string reviever = commandTokens[2];
                        User senderFound = users.FirstOrDefault(u => u.Username == sender.ToString());
                        User recieverFound = users.FirstOrDefault(u => u.Username == reviever.ToString());
                        if (senderFound != null && recieverFound != null) //both exist
                        {
                            senderFound.SentMessages++;
                            recieverFound.RecievedMessages++;
                            if (senderFound.SentMessages + senderFound.RecievedMessages >= capacity)
                            {
                                users.Remove(senderFound);
                                Console.WriteLine($"{senderFound.Username} reached the capacity!");
                            }
                            if (recieverFound.RecievedMessages + recieverFound.SentMessages >= capacity)
                            {
                                users.Remove(recieverFound);
                                Console.WriteLine($"{recieverFound.Username} reached the capacity!");
                            }
                        }
                        break;
                    case "Empty":
                        string userToEmpty = commandTokens[1];
                        if (userToEmpty == "All")
                        {
                            users.Clear(); //possible problem
                        }
                        else
                        {
                            User foundUser = users.FirstOrDefault(u => u.Username == userToEmpty.ToString());
                            if (foundUser != null) //user exists
                            {
                                users.Remove(foundUser);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine($"Users count: {users.Count}");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.Username} - {user.Total()}");
            }
        }
    }
}