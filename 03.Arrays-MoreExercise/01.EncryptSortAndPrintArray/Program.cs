namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            int[] encryptedNames = new int[n];
            for (int i = 0; i < n; i++)
            {
                names[i] = Console.ReadLine();
                string currentName = names[i];
                int currentNameSum = 0;
                for (int j = 0; j < currentName.Length; j++)
                {
                    switch (currentName[j])
                    {
                        case 'a':
                            currentNameSum += currentName[j] * currentName.Length;
                            break;
                        case 'e':
                            currentNameSum += currentName[j] * currentName.Length;
                            break;
                        case 'i':
                            currentNameSum += currentName[j] * currentName.Length;
                            break;
                        case 'o':
                            currentNameSum += currentName[j] * currentName.Length;
                            break;
                        case 'u':
                            currentNameSum += currentName[j] * currentName.Length;
                            break;
                        case 'A':
                            currentNameSum += currentName[j] * currentName.Length;
                            break;
                        case 'E':
                            currentNameSum += currentName[j] * currentName.Length;
                            break;
                        case 'I':
                            currentNameSum += currentName[j] * currentName.Length;
                            break;
                        case 'O':
                            currentNameSum += currentName[j] * currentName.Length;
                            break;
                        case 'U':
                            currentNameSum += currentName[j] * currentName.Length;
                            break;
                        default:
                            currentNameSum += currentName[j] / currentName.Length;
                            break;
                    }
                }
                encryptedNames[i] = currentNameSum;
            }
            for (int i = 0; i < encryptedNames.Length; i++)
            {
                int tempIndex = 0;
                int min = encryptedNames[i];
                for (int j = i; j < encryptedNames.Length; j++)
                {
                    if (min > encryptedNames[j] )
                    {
                        min = encryptedNames[j];
                        tempIndex = j;
                    }
                }
                int temp = encryptedNames[i];
                encryptedNames[i] = min;
                encryptedNames[tempIndex] = temp;
                Console.WriteLine(encryptedNames[i]);
            }
           
        }
    }
}