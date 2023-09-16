using System;
using System.Data.Common;

namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            MessageParts messageParts = new MessageParts();
            for (int i = 0; i < numberOfMessages; i++)
            {
                Console.WriteLine($"{messageParts.Phrases[messageParts.GetRandomIndex("phrases")]} {messageParts.Events[messageParts.GetRandomIndex("events")]} {messageParts.Authors[messageParts.GetRandomIndex("authors")]} – {messageParts.Cities[messageParts.GetRandomIndex("cities")]}.");
            }
        }
    }
    public class MessageParts
    {
        public MessageParts()
        {
            Phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            Events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            Authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            Cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
        }
        public List<string> Phrases { get; set; }
        public List<string> Events { get; set; }
        public List<string> Authors { get; set; }
        public List<string> Cities { get; set; }

        public int GetRandomIndex(string type)
        {
            if (type == "phrases")
            {
                Random random = new Random();
                int index = random.Next(0, Phrases.Count - 1);
                return index;
            }
            else if (type == "events")
            {
                Random random = new Random();
                int index = random.Next(0, Events.Count - 1);
                return index;
            }
            else if (type == "authors")
            {
                Random random = new Random();
                int index = random.Next(0, Authors.Count - 1);
                return index;
            }
            else
            {
                Random random = new Random();
                int index = random.Next(0, Cities.Count - 1);
                return index;
            }
        }
    }
}