namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte waterTankCapacity = 255;
            byte numbersOfPours = byte.Parse(Console.ReadLine());
            short currentTankLevel = 0;
            for (int i = 0; i < numbersOfPours; i++)
            {
                short litersToPour = short.Parse(Console.ReadLine());               
                if (currentTankLevel + litersToPour > waterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    currentTankLevel += litersToPour;
                }
            }
            Console.WriteLine(currentTankLevel);
        }
    }
}