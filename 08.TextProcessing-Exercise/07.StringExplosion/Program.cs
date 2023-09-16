using System.Reflection;
using System.Text;

namespace _07.StringExplosion
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] divided = input.Split('>');

            int explosionPower = 0;
            int remainingExplosionStrength = 0;
            for (int i = 1; i < divided.Length; i++)
            {
                explosionPower = int.Parse("" + divided[i][0]) + remainingExplosionStrength;
                remainingExplosionStrength = explosionPower - divided[i].Length;

                if (explosionPower > divided[i].Length)
                    explosionPower = divided[i].Length;

                divided[i] = divided[i].Substring(explosionPower);
                if (remainingExplosionStrength < 0)
                    remainingExplosionStrength = 0;
            }

            String result = String.Join(">", divided);
            Console.WriteLine(result);
        }
    }
}