namespace _10.LadyBugs
{
    //{ladybugindex} {direction} {fly length}
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] ladyBugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < ladyBugsIndexes.Length; i++)
            {
                if (ladyBugsIndexes[i] >= 0 && ladyBugsIndexes[i] < field.Length)
                {
                    field[ladyBugsIndexes[i]] = 1;
                }
            }

            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                int ladyBugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);
                if (direction == "right")
                {
                    if (ladyBugIndex < field.Length && ladyBugIndex >= 0 && field[ladyBugIndex] == 1)
                    {
                        field[ladyBugIndex] = 0;
                        if (ladyBugIndex + flyLength < field.Length && field[ladyBugIndex + flyLength] == 1)
                        {
                            while (ladyBugIndex + flyLength < field.Length && field[ladyBugIndex + flyLength] == 1)
                            {
                                ladyBugIndex += flyLength;
                                if (ladyBugIndex + flyLength < field.Length && field[ladyBugIndex + flyLength] == 0)
                                {
                                    field[ladyBugIndex + flyLength] = 1;
                                    break;
                                }

                                else
                                {
                                    continue;
                                }
                            }
                        }

                        else if (ladyBugIndex + flyLength < field.Length && field[ladyBugIndex + flyLength] == 0)
                        {
                            field[ladyBugIndex + flyLength] = 1;
                            continue;
                        }
                    }

                    else
                    {
                        continue;
                    }
                }

                else if (direction == "left")
                {
                    if (ladyBugIndex < field.Length && ladyBugIndex >= 0 && field[ladyBugIndex] == 1)
                    {
                        field[ladyBugIndex] = 0;
                        if (ladyBugIndex - flyLength >= 0 && field[ladyBugIndex - flyLength] == 1)
                        {
                            while (ladyBugIndex - flyLength >= 0 && field[ladyBugIndex - flyLength] == 1)
                            {
                                ladyBugIndex -= flyLength;
                                if (ladyBugIndex - flyLength >= 0 && field[ladyBugIndex - flyLength] == 0)
                                {
                                    field[ladyBugIndex - flyLength] = 1;
                                    break;
                                }

                                else
                                {
                                    continue;
                                }
                            }
                        }

                        else if (ladyBugIndex - flyLength >= 0 && field[ladyBugIndex - flyLength] == 0)
                        {
                            field[ladyBugIndex - flyLength] = 1;
                            continue;
                        }
                    }

                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}