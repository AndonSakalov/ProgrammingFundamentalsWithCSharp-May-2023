namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < songsCount; i++)
            {
                string[] data = Console.ReadLine().Split("_").ToArray();
                string type = data[0];
                string name = data[1];
                string time = data[2];
                
                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;
                
                songs.Add(song);
            }
            string typeList = Console.ReadLine();
            if(typeList == "all")
            {
                for (int i = 0; i < songs.Count; i++)
                {
                    Console.WriteLine(songs[i].Name);
                }
            }
            else
            {
                for (int i = 0; i < songs.Count; i++)
                {
                    if (songs[i].TypeList == typeList)
                    {
                        Console.WriteLine(songs[i].Name);
                    }
                }
            }
        }
    }
    public class Song
    {
        public string TypeList { get; set;}
        public string Name { get; set;}
        public string Time { get; set;}
    }
}