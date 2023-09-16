namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(", ");
            bool isValid = true;
            List<string> validUsernames = new List<string>();
            for (int i = 0; i < strArr.Length; i++)
            {
                isValid = true;
                if (strArr[i].Length < 3 || strArr[i].Length > 16)
                {
                    isValid = false;
                }
                foreach (char character in strArr[i])
                {
                    if (!(char.IsLetter(character) || char.IsNumber(character) || character == '-' || character == '_'))
                    {
                        isValid = false;
                    }
                }
                if (isValid)
                {
                    validUsernames.Add(strArr[i]);
                }
            }
            Console.WriteLine(string.Join("\n", validUsernames));
        }
    }
}