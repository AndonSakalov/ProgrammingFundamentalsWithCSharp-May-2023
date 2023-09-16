using System.Buffers;
using System.Security.Authentication;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "exchange":
                        int index = int.Parse(command[1]);
                        if (index < 0 || index > arr.Length - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            arr = Exchange(index, arr);
                        }
                        break;
                    case "max":
                        if (command[1] == "even")
                        {
                            int maxEven = ReturnMaxEvenIndex(arr);
                            if (maxEven < 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(maxEven);
                            }
                        }
                        else if (command[1] == "odd")
                        {
                            int maxOdd = ReturnMaxOddIndex(arr);
                            if (maxOdd < 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(maxOdd);
                            }
                        }
                        break;
                    case "min":
                        if (command[1] == "even")
                        {
                            int minEven = ReturnMinEvenIndex(arr);
                            if (minEven < 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(minEven);
                            }
                        }
                        else if (command[1] == "odd")
                        {
                            int minOdd = ReturnMinOdd(arr);
                            if (minOdd < 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(minOdd);
                            }
                        }
                        break;
                    case "first":
                        int firstNumbersCount = int.Parse(command[1]);
                        if (command[2] == "even")
                        {
                            if (firstNumbersCount > arr.Length)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                string firstEvenNumbers = FirstEvenNumbers(arr, firstNumbersCount).Trim();
                                string[] firstEvenNumbersArr = firstEvenNumbers.Split(" ").ToArray();
                                Console.WriteLine($"[{string.Join(", ", firstEvenNumbersArr)}]");
                            }
                        }
                        else if (command[2] == "odd")
                        {
                            if (firstNumbersCount > arr.Length)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                string firstOddNumbers = FirstOddNumbers(arr, firstNumbersCount).Trim();
                                string[] firstOddNumbersArr = firstOddNumbers.Split(" ").ToArray();
                                Console.WriteLine($"[{string.Join(", ", firstOddNumbersArr)}]");
                            }

                        }
                        break;
                    case "last":
                        int lastNumbersCount = int.Parse(command[1]);
                        if (command[2] == "even")
                        {
                            if (lastNumbersCount > arr.Length)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                string lastEvenNumbers = LastEvenNumbers(arr, lastNumbersCount).Trim();
                                string[] lastEvenNumbersArr = lastEvenNumbers.Split(" ").ToArray();
                                Array.Reverse(lastEvenNumbersArr);
                                Console.WriteLine($"[{string.Join(", ", lastEvenNumbersArr)}]");
                            }
                        }
                        else if (command[2] == "odd")
                        {
                            if (lastNumbersCount > arr.Length)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                string lastOddNumbers = LastOddNumbers(arr, lastNumbersCount).Trim();
                                string[] lastOddNumbersArr = lastOddNumbers.Split(" ").ToArray();
                                Array.Reverse(lastOddNumbersArr);
                                Console.WriteLine($"[{string.Join(", ", lastOddNumbersArr)}]");
                            }
                        }
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        private static string LastOddNumbers(int[] arr, int numbersCount)
        {
            string lastOddNumbers = string.Empty;
            int counter = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 != 0)
                {
                    counter++;
                    if (counter == numbersCount)
                    {
                        lastOddNumbers += arr[i];
                    }
                    else
                    {
                        lastOddNumbers += arr[i] + " ";
                    }
                }
                if (counter == numbersCount)
                {
                    break;
                }
            }

            return lastOddNumbers;
        }

        private static string LastEvenNumbers(int[] arr, int numbersCount)
        {
            string lastEvenNumbers = string.Empty;
            int counter = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    counter++;
                    if (counter == numbersCount)
                    {
                        lastEvenNumbers += arr[i];
                    }
                    else
                    {
                        lastEvenNumbers += arr[i] + " ";
                    }
                }
                if (counter == numbersCount)
                {
                    break;
                }
            }
            return lastEvenNumbers;
        }

        static string FirstOddNumbers(int[] arr, int numbersCount)
        {
            string firstOddNumbers = string.Empty;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    counter++;
                    if (counter == numbersCount)
                    {
                        firstOddNumbers += arr[i];
                    }
                    else
                    {
                        firstOddNumbers += arr[i] + " ";
                    }

                }
                if (counter == numbersCount)
                {
                    break;
                }
            }
            return firstOddNumbers;
        }

        static string FirstEvenNumbers(int[] arr, int numbersCount)
        {
            string firstEvenNumbers = string.Empty;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    counter++;
                    if (counter == numbersCount)
                    {
                        firstEvenNumbers += arr[i];
                    }
                    else
                    {
                        firstEvenNumbers += arr[i] + " ";
                    }

                }
                if (counter == numbersCount)
                {
                    break;
                }
            }
            return firstEvenNumbers;
        }

        static int ReturnMinOdd(int[] arr)
        {
            int minOddNumberIndex = 0;
            int minOddNumber = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (arr[i] <= minOddNumber)
                    {
                        minOddNumberIndex = i;
                        minOddNumber = arr[i];
                    }
                }
            }
            if (minOddNumber == int.MaxValue)
            {
                return -1;
            }
            else
            {
                return minOddNumberIndex;
            }
        }

        static int ReturnMinEvenIndex(int[] arr)
        {
            int minEvenNumberIndex = 0;
            int minEvenNumber = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] <= minEvenNumber)
                    {
                        minEvenNumberIndex = i;
                        minEvenNumber = arr[i];
                    }
                }
            }
            if (minEvenNumber == int.MaxValue)
            {
                return -1;
            }
            else
            {
                return minEvenNumberIndex;
            }
        }

        static int ReturnMaxOddIndex(int[] arr)
        {
            int maxOddNumberIndex = 0;
            int maxOddNumber = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (arr[i] >= maxOddNumber)
                    {
                        maxOddNumberIndex = i;
                        maxOddNumber = arr[i];
                    }
                }
            }
            if (maxOddNumber == int.MinValue)
            {
                return -1;
            }
            else
            {
                return maxOddNumberIndex;
            }
        }

        static int ReturnMaxEvenIndex(int[] arr)
        {
            int maxEvenNumberIndex = 0;
            int maxEvenNumber = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] >= maxEvenNumber)
                    {
                        maxEvenNumberIndex = i;
                        maxEvenNumber = arr[i];
                    }
                }
            }
            if (maxEvenNumber == int.MinValue)
            {
                return -1;
            }
            else
            {
                return maxEvenNumberIndex;
            }
        }

        static int[] Exchange(int index, int[] arr)
        {
            for (int i = 0; i <= index; i++)
            {
                int temp = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];

                }
                arr[arr.Length - 1] = temp;
            }
            return arr;
        }
    }
}