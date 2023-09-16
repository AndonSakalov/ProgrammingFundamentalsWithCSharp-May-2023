using System.Numerics;

namespace _04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger[] arr = new BigInteger[n];
            TribonacciSequence(n, arr);
        }

        static void TribonacciSequence(int n, BigInteger[] arr)
        {
            for (int i = 0; i <= n - 1; i++)
            {
                if (i == 2)
                {
                    arr[0] = 1;
                    arr[1] = 1;
                    arr[2] = 2;
                }
                else if (i == 1)
                {
                    arr[0] = 1;
                    arr[1] = 1;
                }
                else if (i == 0)
                {
                    arr[0] = 1;
                }
                else
                {
                    arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
                }
            }
            Console.WriteLine(string.Join(" ", arr)); 
        }
    }
}