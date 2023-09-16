namespace Problem1
{
    /*

    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandTokens = input.Split();
                switch (commandTokens[0])
                {
                    case "Translate":
                        char charToReplace = char.Parse(commandTokens[1]);
                        char replacingChar = char.Parse(commandTokens[2]);
                        str = str.Replace(charToReplace, replacingChar);
                        Console.WriteLine(str);
                        break;
                    case "Includes":
                        string substring = commandTokens[1];
                        if (str.Contains(substring))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Start":
                        bool startWithIt = true;
                        string substr = commandTokens[1];
                        for (int i = 0; i < substr.Length; i++)
                        {
                            if (!(str[i] == substr[i]))
                            {
                                startWithIt = false;
                            }
                        }
                        if (startWithIt)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Lowercase":
                        str = str.ToLower();
                        Console.WriteLine(str);
                        break;
                    case "FindIndex":
                        char chr = char.Parse(commandTokens[1]);
                        int lastoccurance = 0;
                        for (int i = str.Length - 1; i >= 0; i--)
                        {
                            if (chr == str[i])
                            {
                                lastoccurance = i;
                                break;
                            }
                        }
                        if (lastoccurance != 0)
                        {
                            Console.WriteLine(lastoccurance);
                        }
                        break;
                    case "Remove":
                        int startIndex = int.Parse(commandTokens[1]);
                        int count = int.Parse(commandTokens[2]);
                        str = str.Remove(startIndex, count);
                        Console.WriteLine(str);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}