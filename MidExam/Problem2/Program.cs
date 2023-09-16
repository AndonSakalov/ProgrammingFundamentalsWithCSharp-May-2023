namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] travelRoute = Console.ReadLine().Split("||").ToArray();
            int startingAmountOfFuel = int.Parse(Console.ReadLine());
            int startingAmountOfAmmo = int.Parse(Console.ReadLine());
            for (int i = 0; i < travelRoute.Length; i++)
            { 
                string current = travelRoute[i];
                string[] commands = current.Split(' ');
                switch (commands[0])
                {
                    case "Travel":
                        int lightYears = int.Parse(commands[1]);
                        if (lightYears <= startingAmountOfFuel)
                        {
                            startingAmountOfFuel -= lightYears;
                            Console.WriteLine($"The spaceship travelled {lightYears} light-years.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                        break;
                    case "Enemy":
                        int enemyArmor = int.Parse(commands[1]);
                        if (startingAmountOfAmmo >= enemyArmor)
                        {
                            startingAmountOfAmmo -= enemyArmor;
                            Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");
                        }
                        else
                        {
                            if (startingAmountOfFuel >= enemyArmor * 2)
                            {
                                startingAmountOfFuel -= enemyArmor * 2;
                                Console.WriteLine($"An enemy with {enemyArmor} armour is outmaneuvered.");
                            }
                            else
                            {
                                Console.WriteLine("Mission failed.");
                                return;
                            }
                        }
                        break;
                    case "Repair":
                        int fuelAdded = int.Parse(commands[1]);
                        int ammoAdded = int.Parse(commands[1]);
                        startingAmountOfFuel += fuelAdded;
                        startingAmountOfAmmo += ammoAdded * 2;
                        Console.WriteLine($"Ammunitions added: {ammoAdded * 2}.");
                        Console.WriteLine($"Fuel added: {fuelAdded}.");
                        break;
                    case "Titan":
                        Console.WriteLine("You have reached Titan, all passengers are safe.");
                        return;
                        break;
                }
            }
        }
    }
}