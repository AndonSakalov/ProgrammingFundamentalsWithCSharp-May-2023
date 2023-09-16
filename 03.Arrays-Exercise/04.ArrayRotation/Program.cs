using System.Buffers;
using System.Runtime.ExceptionServices;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int firstElement = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = firstElement;
            }
            Console.WriteLine(string.Join(" ", arr));

            // 1 2 3 4 
            //  0 1 2 3
        }
    }
}