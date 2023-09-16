namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string[] articleParts = input.Split(", ");
            string title = articleParts[0];
            string content = articleParts[1];
            string author = articleParts[2];
            Article article = new Article(title, content, author);
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split(": ");
                switch (tokens[0])
                {
                    case "Edit":
                        string newContent = tokens[1];
                        article.Edit(newContent, article);
                    break;
                    case "ChangeAuthor":
                        string newAuthor = tokens[1];
                        article.ChangeAuthor(newAuthor, article);
                        break;
                    case "Rename":
                        string newTitle = tokens[1];
                        article.Rename(newTitle, article);
                        break;
                }
            }
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article Edit(string newContent, Article article)
        {
            article.Content = newContent;
            return article;
        }
        public Article ChangeAuthor(string newAuthor, Article article)
        {
            article.Author = newAuthor;
            return article;
        }
        public Article Rename(string newTitle, Article article)
        {
            article.Title = newTitle;
            return article;
        }
    }
}