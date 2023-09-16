namespace _09.PokemonDon_tGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            int currentIndexValue = 0;
            while (pokemons.Count > 0)
            {
                int currentIndex = int.Parse(Console.ReadLine());
                if (currentIndex < 0) //Possible problem here!
                {
                    currentIndexValue = pokemons[0];
                    sum += pokemons[0];
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, pokemons[pokemons.Count - 1]);
                    IncreaseOrDecreaseValueOfPokemons(pokemons, currentIndexValue);
                }
                else if (currentIndex > pokemons.Count - 1)
                {
                    currentIndexValue = pokemons[pokemons.Count - 1];
                    sum += currentIndexValue;
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Add(pokemons[0]);
                    IncreaseOrDecreaseValueOfPokemons(pokemons, currentIndexValue);
                }
                else
                {
                    currentIndexValue = pokemons[currentIndex];
                    pokemons.RemoveAt(currentIndex);
                    sum += currentIndexValue;
                    IncreaseOrDecreaseValueOfPokemons(pokemons, currentIndexValue);
                }
            }
            Console.WriteLine(sum);
        }

        static List<int> IncreaseOrDecreaseValueOfPokemons(List<int> pokemons, int currentIndexValue)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= currentIndexValue)
                {
                    pokemons[i] += currentIndexValue;
                }
                else if (pokemons[i] > currentIndexValue)
                {
                    pokemons[i] -= currentIndexValue;
                }
            }
            return pokemons;
        }
    }
}