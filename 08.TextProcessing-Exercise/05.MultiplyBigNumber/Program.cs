using System.Data;
using System.Numerics;
using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            string multiplyNumber = Console.ReadLine();
            Console.WriteLine(Multiply(bigNumber, multiplyNumber).ToString());
        }

        private static string Multiply(string bigNumber, string multiplyNumber)
        {
            if (multiplyNumber == "0" || bigNumber == "0")
            {
                return "0";
            }
            int carry = 0;
            int multiplyNum = int.Parse(multiplyNumber);
            StringBuilder sb = new StringBuilder();
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(bigNumber[i].ToString());
                int result = multiplyNum * digit + carry;
                sb.Insert(0, (char)(result % 10 + '0'));
                carry = result / 10;
            }
            if (carry > 0)
            {
                sb.Insert(0, (char)(carry + '0'));
            }
            return sb.ToString();
        }
    }
}