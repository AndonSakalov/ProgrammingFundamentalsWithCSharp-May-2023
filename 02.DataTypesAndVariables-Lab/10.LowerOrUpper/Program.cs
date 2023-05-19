namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            bool isUpper = char.IsUpper(char1);
            switch (isUpper)
            {
                case true:
                    Console.WriteLine("upper-case");
                    break;
                case false:
                    Console.WriteLine("lower-case");
                    break;
            }
        }
    }
}