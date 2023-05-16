namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money = float.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            float pricePerSaber = float.Parse(Console.ReadLine());
            float pricePerRobe = float.Parse(Console.ReadLine());
            float pricePerBelt = float.Parse(Console.ReadLine());
            int sabersCount = (int)Math.Ceiling(studentsCount + 0.10 * studentsCount);  
            int robesCount = studentsCount;
            int beltsCount = studentsCount;
            int beltsCount2 = beltsCount - beltsCount / 6;
            double totalCost = pricePerSaber * sabersCount + robesCount * pricePerRobe + beltsCount2 * pricePerBelt;
            if (totalCost <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {totalCost - money:F2}lv more.");
            }
        }
    }
}