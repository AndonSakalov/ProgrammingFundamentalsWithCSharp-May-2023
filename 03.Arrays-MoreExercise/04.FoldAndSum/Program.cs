namespace _04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        { //1 2 3 4 5 6 7 8
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] outer = new int[arr.Length / 4];
            int[] outer1 = new int[arr.Length / 4];
            int[] inner = new int[arr.Length / 2];
            int[] wholeOuter = new int[outer.Length * 2];
            int innerIndex = 0;
            int innerIndex1 = 0;
            int x = arr.Length / 4;

            for (int j = 0; j < arr.Length / 4; j++)
            {
                //outer[j] = arr[j];
                outer[j] = arr[j];
            }
            for (int k = arr.Length - 1; k > arr.Length / 2 + 1; k--)
            {
                outer1[innerIndex] = arr[k];
                innerIndex++;
            }
            for (int z = arr.Length / 4; z <= arr.Length / 2 + 1; z++)
            {
                inner[innerIndex1] = arr[z];
                innerIndex1++;
            }
            for (int i = 0; i < outer.Length; i++)
            {
                wholeOuter[i] = outer[i];
            }
            for (int i = wholeOuter.Length - 1; i >= wholeOuter.Length / 2; i--)
            {
                wholeOuter[i] = outer1[outer.Length - x];
                x--;
            }
            for (int i = 0; i < arr.Length / 4; i++)
            {
               // Console.Write();
            }
            //Console.WriteLine(string.Join(" ", outer));

        }
    }
}