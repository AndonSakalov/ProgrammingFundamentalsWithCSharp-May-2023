namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int sequenceLength = int.Parse(Console.ReadLine());
            string input = "";
            int[] sequence = new int[sequenceLength];
            int[] bestSequence = new int[sequenceLength];
            bool isFirstTime = true;
            int bestDNASampleIndex = 1;
            int counter = 1;
            int bestSum = 0;
            //calculations
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int doubleOnes = 0;
                int bestSequenceDoubleOnes = 0;
                bool areEqual = true;
                int currentSum = 0;
                sequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (isFirstTime)
                {
                    bestSequence = sequence;
                    isFirstTime = false;
                    for (int i = 0; i < sequence.Length; i++)
                    {
                        bestSum += sequence[i];
                    }
                }
                else
                {
                    counter++;
                    for (int i = 0; i < sequence.Length - 1; i++)
                    {
                        currentSum += sequence[i] + sequence[sequence.Length - 1];
                        if (sequence[i] + sequence[i + 1] == 2)
                        {
                            doubleOnes++;
                        }
                        if (bestSequence[i] + bestSequence[i + 1] == 2)
                        {
                            bestSequenceDoubleOnes++;
                        }
                    }
                    for (int i = 0; i < sequence.Length - 1; i++) // posible problem here
                    {
                        if (sequence[i] + sequence[i + 1] == 2 && bestSequence[i] + bestSequence[i + 1] != 2 && doubleOnes >= bestSequenceDoubleOnes)
                        {
                            bestSequence = sequence;
                            bestDNASampleIndex = counter;
                            break;
                        }
                        else if (sequence[i] + sequence[i + 1] == 2 && bestSequence[i] + bestSequence[i + 1] == 2 && doubleOnes >= bestSequenceDoubleOnes && currentSum >= bestSum)
                        {
                            bestDNASampleIndex = counter;
                            bestSequence = sequence;
                            bestSum = currentSum;
                            break;
                        }
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < bestSequence.Length; i++)
            {
                if (bestSequence[i] == 1)
                {
                    sum++;
                }
            }
            //output
            Console.WriteLine($"Best DNA sample {bestDNASampleIndex} with sum: {sum}.");
            Console.WriteLine($"{string.Join(" ", bestSequence)}");
        }
    }
}
