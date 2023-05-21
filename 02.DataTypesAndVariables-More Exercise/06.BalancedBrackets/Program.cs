namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isBalanced = true;
            string lastBracket = default;
            int bracketsCount = 0;
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                if (str == "(" || str == ")")
                {
                    bracketsCount++;
                    if (lastBracket == str)
                    {
                        isBalanced = false;
                    }
                    lastBracket = str;
                }
            }
            if (isBalanced && bracketsCount % 2 == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}