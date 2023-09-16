namespace _03.Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfArticles = int.Parse(Console.ReadLine());
            ArticleCollection collection = new ArticleCollection();
            for (int i = 0; i < numbersOfArticles; i++)
            {
                string[] articleParts = Console.ReadLine().Split(", ");
                string title = articleParts[0];
                string content = articleParts[1];
                string author = articleParts[2];
                Article article = new Article(title, content, author);
                collection.Articles.Add(article);
            }
            collection.ToString(collection);
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
    }
    public class ArticleCollection
    {
        public ArticleCollection()
        {
            Articles = new List<Article>();
        }
        public List<Article> Articles { get; set;}

        public void ToString(ArticleCollection collection)
        {
            for (int i = 0; i < Articles.Count; i++)
            {
                Console.WriteLine($"{Articles[i].Title} - {Articles[i].Content}: {Articles[i].Author}");
            }
        }
    }
}