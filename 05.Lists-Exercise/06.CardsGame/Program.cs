namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int winningDeckSum = CardsGame(deck1, deck2);
            if (deck1.Count > deck2.Count)
            {
                Console.WriteLine($"First player wins! Sum: {winningDeckSum}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {winningDeckSum}");
            }
        }

        static int CardsGame(List<int> deck1, List<int> deck2)
        {
            while (deck1.Count != 0 && deck2.Count != 0)
            {
                for (int i = 0; i < deck1.Count; i++)
                {
                    if (deck1.Count == 0 || deck2.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (deck1[i] > deck2[i])
                        {
                            deck1.Add(deck2[i]);
                            deck1.Add(deck1[i]);
                            deck1.RemoveAt(i);
                            deck2.RemoveAt(i);
                            i--;
                        }
                        else if (deck1[i] < deck2[i])
                        {
                            deck2.Add(deck1[i]);
                            deck2.Add(deck2[i]);
                            deck2.RemoveAt(i);
                            deck1.RemoveAt(i);
                            i--;
                        }
                        else
                        {
                            deck1.RemoveAt(i);
                            deck2.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            int sum = 0;
            if (deck1.Count > deck2.Count)
            {
                for (int i = 0; i < deck1.Count; i++)
                {
                    sum += deck1[i];
                }
            }
            else
            {
                for (int i = 0; i < deck2.Count; i++)
                {
                    sum += deck2[i];
                }
            }
            return sum;
        }
    }
}