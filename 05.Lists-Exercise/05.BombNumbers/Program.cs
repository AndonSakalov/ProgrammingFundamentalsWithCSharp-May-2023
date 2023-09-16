using System.Net;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombNumberAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bombNumberAndPower[0];
            int power = bombNumberAndPower[1];
            BombDetonation(list, bombNumber, power);
            int sum = SumOfNumbersLeft(list);
            Console.WriteLine(sum);
        }

        static int SumOfNumbersLeft(List<int> list)
        {
            int sumOfNumbersLeft = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sumOfNumbersLeft += list[i];
            }
            return sumOfNumbersLeft;
        }

        static List<int> BombDetonation(List<int> list, int bombNumber, int power)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bombNumber)
                {
                    for (int j = 1; j <= power; j++)
                    {
                        if (i - 1 >= 0)
                        {
                            list.RemoveAt(i - 1);
                            i--;
                        }
                        else
                        {
                            break;
                        }

                    }
                    for (int j = 1; j <= power; j++)
                    {
                        if (i + 1 < list.Count)
                        {
                            list.RemoveAt(i + 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                    list.Remove(bombNumber);
                    i = -1;
                }
            }
            return list;
        }
    }
}