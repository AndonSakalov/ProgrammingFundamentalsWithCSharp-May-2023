namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = true;
            if (!CharactersLengthChecker(password))
            {
                isValid = false;
            }
            if (!LettersAndDigitsChecker(password))
            {
                isValid = false;
            }
            if (!Atleast2DigitsChecker(password))
            {
                isValid = false;
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool Atleast2DigitsChecker(string password)
        {
            bool isValid = true;
            int digitsCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    digitsCount++;
                }
            }
            if (digitsCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            return isValid;
        }

        static bool LettersAndDigitsChecker(string password)
        {
            bool isValid = true;
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 48 && password[i] <= 57) || (password[i] >= 97 && password[i] <= 122) || (password[i] >= 65 && password[i] <= 90))
                {

                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }

        static bool CharactersLengthChecker(string password)
        {
            bool isValid = true;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            return isValid;
        }
    }
}