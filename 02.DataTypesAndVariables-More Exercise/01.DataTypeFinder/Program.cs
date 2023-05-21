namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string dataType = default;
            int tryInt = default;
            float tryFloat = default;
            char tryChar = default;
            bool tryBool = default;
            while (input != "END")
            {
                if (Int32.TryParse(input, out tryInt))
                {
                    dataType = "integer";
                }
                else if (Single.TryParse(input, out tryFloat))
                {
                    dataType = "floating point";
                }
                else if (Char.TryParse(input, out tryChar))
                {
                    dataType = "character";
                }
                else if (Boolean.TryParse(input, out tryBool))
                {
                    dataType = "boolean";
                }
                else 
                {
                    dataType = "string";
                }
                Console.WriteLine($"{input} is {dataType} type"); 
                input = Console.ReadLine();
            }
        }
    }
}