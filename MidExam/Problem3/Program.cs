using System.Linq;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "Chat":
                        string message = commands[1];
                        //if (list.Count == 0)
                        //{
                            list.Add(message);
                        //}
                        //else
                        //{
                        //    list.Insert(list.Count - 1, message);
                        //}
                        break;
                    case "Delete":
                        string messageToDelete = commands[1];
                        if (list.Contains(messageToDelete))
                        {
                            list.Remove(messageToDelete); //possible
                        }
                        break;
                    case "Edit":
                        string messageToEdit = commands[1];
                        string editedMessage = commands[2];
                        if (list.Contains(messageToEdit))
                        {
                            int index = list.IndexOf(messageToEdit);
                            list[index] = editedMessage;
                        }
                        break;
                    case "Pin":
                        string messageToPin = commands[1];
                        if (list.Contains(messageToPin))
                        {
                            list.Remove(messageToPin); //possible
                            list.Add(messageToPin);
                        }
                        break;
                    case "Spam":
                        for (int i = 1; i < commands.Length; i++)
                        {
                            list.Remove(commands[i]);
                            list.Add(commands[i]);
                        }
                        break;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}