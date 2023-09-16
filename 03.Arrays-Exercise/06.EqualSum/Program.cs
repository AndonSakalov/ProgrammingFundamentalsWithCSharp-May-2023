namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isThereSpecialNumbers = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0, rightSum = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }
                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += arr[k];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    isThereSpecialNumbers = true;
                }
            }
            if (!isThereSpecialNumbers)
            {
                Console.WriteLine("no");
            }
        }
    }
}