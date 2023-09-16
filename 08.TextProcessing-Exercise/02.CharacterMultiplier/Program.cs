namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string str1 = strings[0];
            string str2 = strings[1];
            Console.WriteLine(SumDigits(str1, str2)); 

        }

        static uint SumDigits(string str1, string str2)
        {
            uint sum = 0;
            bool areEqualLength = str1.Length == str2.Length;
            bool str1IsLonger = str1.Length > str2.Length;
            if (areEqualLength)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    sum += (uint)str1[i] * str2[i];
                }
            }
            else if (str1IsLonger)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    sum += (uint)str1[i] * str2[i];
                }
                for (int i = str1.Length - 1; i > str2.Length - 1; i--) // >= possibly
                {
                    sum += str1[i];
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    sum += (uint)str1[i] * str2[i];
                }
                for (int i = str2.Length - 1; i > str1.Length - 1; i--)
                {
                    sum += str2[i];
                }
            }
            return sum;
        }
    }
}