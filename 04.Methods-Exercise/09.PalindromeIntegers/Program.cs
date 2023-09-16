namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = default;
            while ((input = Console.ReadLine())!="END")
            {
                Console.WriteLine(PalindromeChecker(input).ToString().ToLower()); 
            }
        }

        static bool PalindromeChecker(string number)
        {
            char[] numberArray = number.ToCharArray();
            Array.Reverse(numberArray);
            string reversedNumber = new string(numberArray);
            return number.CompareTo(reversedNumber) == 0;
        }
    }
}