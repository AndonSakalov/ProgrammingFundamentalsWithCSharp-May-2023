namespace _04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }
            for (int i = 0; i < products.Count; i++)
            {
                int min = i;
                for (int j = i+1; j < products.Count; j++)
                {
                    if (products[min].CompareTo(products[j]) > 0)
                    {
                        min = j;
                    }
                }
                string temp = products[min];
                products[min] = products[i];
                products[i] = temp;

            }
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
            
        }
    }
}